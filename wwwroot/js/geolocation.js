window.geolocationHelper = {
  getCurrentPosition: function () {
    return new Promise((resolve, reject) => {
      if (!navigator.geolocation) {
        reject(new Error('Geolocation is not supported by this browser.'));
        return;
      }

      navigator.geolocation.getCurrentPosition(
        (position) => {
          resolve({
            latitude: position.coords.latitude,
            longitude: position.coords.longitude,
            accuracy: position.coords.accuracy,
            altitude: position.coords.altitude,
            speed: position.coords.speed,
          });
        },
        (error) => {
          let errorMessage = '';
          switch (error.code) {
            case error.PERMISSION_DENIED:
              errorMessage = 'User denied the request for Geolocation.';
              break;
            case error.POSITION_UNAVAILABLE:
              errorMessage = 'Location information is unavailable.';
              break;
            case error.TIMEOUT:
              errorMessage = 'The request to get user location timed out.';
              break;
            default:
              errorMessage = 'An unknown error occurred.';
              break;
          }
          reject(new Error(errorMessage));
        },
        {
          enableHighAccuracy: true,
          timeout: 10000,
          maximumAge: 0,
        },
      );
    });
  },
  getTimezone: function () {
    return Intl.DateTimeFormat().resolvedOptions().timeZone;
  },

  getLocale: function () {
    return navigator.language || navigator.userLanguage;
  },
  watchPosition: function (dotNetObjectHelper) {
    if (!navigator.geolocation) {
      return -1;
    }
    const watchId = navigator.geolocation.watchPosition(
      (position) => {
        dotNetObjectHelper.invokeMethodAsync('OnPositionChanged', {
          latitude: position.coords.latitude,
          longitude: position.coords.longitude,
          accuracy: position.coords.accuracy,
        });
      },
      (error) => {
        console.error('Error watching position:', error);
      },
      {
        enableHighAccuracy: true,
        timeout: 5000,
        maximumAge: 0,
      },
    );
    return watchId;
  },
  clearWatch: function (watchId) {
    if (watchId !== -1) {
      navigator.geolocation.clearWatch(watchId);
    }
  },
};
