# 🚗 Vehicle Rental System

A simple and user-friendly desktop application developed using **C# (.NET)** and **Windows Forms** that allows users to manage a fleet of vehicles for a rental service.

## 🛠️ Features

- ➕ Add new vehicles (Cars and Motorbikes) with specific attributes:
  - Cars: Number of doors
  - Motorbikes: Presence of a sidecar
- 🗂️ View a list of registered vehicles with detailed information:
  - Registration number, brand, year, rental status, and specific details (e.g., doors or sidecar)
- 📝 Update vehicle information (via re-adding or modifying)
- ❌ Delete vehicles from the list
- 🚗 Rent vehicles and mark them as "Rented"
- 🔄 Return rented vehicles and mark them as "Available"
- 🧼 Clean, intuitive UI with responsive layout
- 💾 Local data management (currently in-memory, extendable to file storage or database)

## 📂 Project Structure

```
.
├── Models/
│   ├── Car.cs
│   ├── Motorbike.cs
│   └── Vehicle.cs
├── .gitattributes
├── .gitignore
├── AddVehicleForm.Designer.cs
├── AddVehicleForm.cs
├── AddVehicleForm.resx
├── MainForm.Designer.cs
├── MainForm.cs
├── MainForm.resx
├── Program.cs
├── README.md
├── VehicleRentalSystem.csproj
└── VehicleRentalSystem.sln
```

> 📌 You can modify the structure based on how your app is organized.

## 🧑‍💻 Tech Stack

- **Language:** C#
- **Framework:** .NET Windows Forms App
- **IDE:** Visual Studio 2022/2023 Community Edition
- **Data Storage:** In-memory (extendable to plain text files or SQLite)

## 🖼️ Screenshots

> Add screenshots here (e.g., main dashboard, add vehicle form, vehicle list, etc.)

## 🔧 Setup Instructions

1. Clone the repository:
   
   ```bash
   git clone https://github.com/R-Tharanka/VehicleRentalSystem.git

	```
2. Open the `.sln` file in Visual Studio.
3. Build the solution (__Ctrl + Shift + B__).
4. Run the application (__F5__).

## 📌 Usage

1. **Add Vehicle**:
   - Click "Add Vehicle" to register a new vehicle.
   - Choose the vehicle type (Car or Motorbike) and fill in the relevant details.
   - The UI adapts fields like "Number of Doors" or "Has Sidecar" based on the selected type.
   - Press "Add" to save the vehicle into the list.

2. **View Vehicles**:
   - The main list displays all registered vehicles with their details:
     - Registration number, brand, year, rental status, and specific attributes.

3. **Rent Vehicle**:
   - Select a vehicle from the list and click "Rent" to mark it as rented.
   - If the vehicle is already rented, a message will notify you.

4. **Return Vehicle**:
   - Select a rented vehicle and click "Return" to mark it as available.

5. **Delete Vehicle**:
   - Select a vehicle and click "Delete" to remove it from the list.
   - A confirmation dialog will appear before deletion.

## 🚀 Future Enhancements

- 🔐 Add login and registration system for user authentication.
- 💾 Implement local data persistence using text files or SQLite.
- 📊 Add reporting features (e.g., rental history, revenue tracking).
- 🧾 Manage rental details (e.g., customer information, rental duration).
- 🌐 Explore cloud-based data storage for scalability.

---

Feel free to contribute to the project or suggest improvements!
