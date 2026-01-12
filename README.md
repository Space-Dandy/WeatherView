# 🌤️ WeatherView

> A minimalist weather app built with Blazor & Tailwind CSS

Get real-time weather information based on your location with a beautiful glassmorphism UI.

![Blazor](https://img.shields.io/badge/Blazor-512BD4?style=flat&logo=blazor&logoColor=white)
![.NET](https://img.shields.io/badge/.NET-10.0-512BD4?style=flat&logo=.net&logoColor=white)
![TailwindCSS](https://img.shields.io/badge/Tailwind-38B2AC?style=flat&logo=tailwind-css&logoColor=white)

## ✨ Features

- 🌍 **Auto Location Detection** - Browser geolocation with IP fallback
- 🌡️ **Real-time Weather** - Powered by Open-Meteo API
- 🎨 **Glassmorphism Design** - Modern, clean interface
- 🕐 **Timezone Aware** - Automatically detects your timezone
- 📱 **Responsive** - Works on all devices
- 🚀 **Fast & Lightweight** - No API key required

## 🛠️ Tech Stack

- **Frontend:** Blazor Server with Interactive rendering
- **Styling:** Tailwind CSS v4
- **Weather API:** [Open-Meteo](https://open-meteo.com/)
- **Icons:** Font Awesome
- **Geolocation:** Browser API + IP-based fallback

## 🚀 Getting Started

### Prerequisites

- [.NET 10 SDK](https://dotnet.microsoft.com/download)
- [Node.js](https://nodejs.org/) (for Tailwind CSS)

### Installation

1. **Clone the repository**
   ```bash
   git clone https://github.com/YOUR_USERNAME/WeatherView.git
   cd WeatherView
   ```

2. **Install dependencies**
   ```bash
   npm install
   ```

3. **Build Tailwind CSS**
   ```bash
   npm run build:css
   ```

4. **Run the app**
   ```bash
   dotnet run
   ```

5. **Open your browser**
   ```
   https://localhost:5213
   ```

### Development

Run both commands in separate terminals for hot reload:

```bash
# Terminal 1 - Watch Tailwind CSS
npm run watch:css

# Terminal 2 - Run Blazor app
dotnet watch run
```

## 📁 Project Structure

```
WeatherView/
├── Components/
│   ├── Pages/
│   │   └── Home.razor          # Main weather page
│   ├── Layout/
│   └── App.razor               # Root component
├── Models/
│   ├── WeatherData.cs          # Weather response models
│   └── GeolocationData.cs      # Location models
├── Services/
│   └── WeatherService.cs       # Weather API service
└── wwwroot/
    ├── js/
    │   └── geolocation.js      # Browser geolocation
    └── css/
```

## 🌈 Features in Detail

### Geolocation Strategy

1. **Primary:** Browser Geolocation API (high accuracy)
2. **Fallback:** IP-based geolocation (ipapi.co)
3. **Default:** Hardcoded location if both fail

### Weather Data

- Current temperature
- Wind speed & direction
- Day/Night indicator
- Weather codes
- Timezone information

## 🤝 Contributing

Contributions are welcome! Feel free to open issues or submit PRs.

## 📝 License

MIT License - feel free to use this project however you'd like!

## 💖 Acknowledgments

- Weather data from [Open-Meteo](https://open-meteo.com/)
- Icons by [Font Awesome](https://fontawesome.com/)
- Built with ❤️ using Blazor

---

<div align="center">
  <sub>Built with 🌤️ by <a href="https://github.com/Space-Dandy">Andrés Treviño</a></sub>
</div>
