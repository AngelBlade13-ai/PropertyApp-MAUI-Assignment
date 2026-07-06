# PropertyApp MAUI Assignment

PropertyApp is a .NET MAUI mobile application that displays a small real-estate browsing experience. The app shows property listings for New York locations, lets the user select a property, and opens a detail screen with the selected property image, price, location, additional images, and action buttons.

This project was built for a .NET MAUI course assignment to demonstrate multi-platform UI development, navigation, MVVM-style data binding, local assets, remote images, and reusable UI controls.

## Project Structure

- `Model/` - Property data model and sample property repository.
- `View/` - XAML pages for the landing page and details page.
- `ViewModel/` - View models used for page bindings and commands.
- `Control/` - Custom UI controls, including a custom border component.
- `Resources/Images/` - App image assets such as `map.png`, `close.png`, and `arrow.png`.
- `Resources/Fonts/` - Custom font files.
- `Resources/Styles/` - Shared MAUI style and color resources.
- `Platforms/` - Platform-specific Android, iOS, Mac Catalyst, and Windows files.

## Features Implemented

- [x] .NET MAUI single-project application structure.
- [x] Landing page with greeting, location header, category filters, and property grid.
- [x] Property cards with images, addresses, and formatted prices.
- [x] Details page navigation when selecting a property.
- [x] Details page with selected property hero image, address, price, thumbnail images, and close button.
- [x] Local image assets for UI icons.
- [x] Remote property images loaded from web URLs.
- [x] MVVM-style binding using view models and commands.
- [x] Custom border control for randomized rounded property images.
- [x] Responsive layout using MAUI Grid, CollectionView, StackLayout, Border, and Image controls.

## Requirements

- Visual Studio 2022 with the .NET MAUI workload installed.
- .NET 10 SDK.
- Android emulator, Android device, or Windows target for testing.
- Internet access for loading remote property images.

## Setup Instructions

1. Clone the repository:

   ```powershell
   git clone <your-repository-url>
   cd PropertyApp-MAUI-Assignment
   ```

2. Open `PropertyApp.slnx` in Visual Studio.

3. Restore NuGet packages:

   ```powershell
   dotnet restore
   ```

4. Select a run target in Visual Studio:

   - Android Emulator for Android testing.
   - Windows Machine for local Windows testing.
   - iOS simulator or device if using a Mac build environment.

5. Build the project:

   ```powershell
   dotnet build PropertyApp.slnx
   ```

6. Run the application from Visual Studio using the selected device or emulator.

## Platform Notes

- Android testing requires an Android emulator or physical Android device configured in Visual Studio.
- iOS testing requires a Mac build host or a macOS environment with the required Apple tooling.
- Some images are loaded from remote URLs, so an internet connection is required for the full visual experience.

## Database Setup

This project does not use a local database or Entity Framework migrations. Property data is currently stored in `Model/PropertyRepo.cs` as in-memory sample data. No database setup is required.

## Demonstration Checklist

For the assignment video or screenshots, demonstrate:

- [ ] App launching on an Android emulator, iOS simulator/device, or Windows target.
- [ ] Landing page with property listings.
- [ ] Category filter buttons visible on the landing page.
- [ ] Selecting a property card.
- [ ] Navigation to the details page.
- [ ] Details page showing the selected property image, address, price, thumbnail images, and close button.
- [ ] Returning from the details page using the close button.

## Challenges and Planned Improvements

- The project currently uses in-memory sample data instead of a database or API.
- Property images are loaded from remote URLs, so image display depends on network availability.
- Future improvements could include search/filter behavior, favorite properties, real CRUD operations, and persistent local storage.

## Build Verification

The project can be checked from the command line with:

```powershell
dotnet build PropertyApp.csproj -f net10.0-windows10.0.19041.0
```

Warnings may appear for deprecated APIs used while following the tutorial, but the project should build with `0 Error(s)`.
