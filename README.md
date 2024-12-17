# Gym Management System

## Project Overview
The Gym Management System is a desktop application designed to streamline the management of gym members and attendance records. Built using **.NET MAUI**, this project incorporates features such as member registration, attendance tracking, and data visualization.

## Features
1. **Member Management**:
   - Add new members with full details (e.g., name, phone, email, join date, and status).
   - Display a list of all members with their attributes.
   - Validate user inputs to ensure data consistency.

2. **Attendance Tracking**:
   - Log member sign-in records with timestamps.
   - Search attendance records by member name or specific date.

3. **Data Persistence**:
   - Store members and attendance logs in CSV files for simplicity and portability.
   - Load and save data asynchronously to ensure smooth application performance.

4. **User-Friendly Interface**:
   - Designed with intuitive navigation and responsive layouts using Razor components.
   - Error messages and validation feedback enhance user experience.


## Project Structure
# **Key Classes**
1. **Attendance**
   - Represents a member’s attendance log with fields such as ID, name, and sign-in time.
2. **Member**
   - Stores member details like ID, name, contact information, join date, and status.
3. **DBManager**
   - Handles data loading, saving, and refreshing for members and attendance.
4. **GymManager**
   - Singleton class managing member and attendance lists.

# **Core Razor Components**
1. **AddMember.razor**:
   - UI for adding new members to the system.
2. **AttendanceTab.razor**:
   - UI for viewing, searching, and logging attendance records.
3. **Members.razor**:
   - UI for displaying the complete member list.
4. **Home.razor**:
   - Welcome page for the application.


## Usage
1. **Add Member**:
   - Navigate to the "Add Member" page from the menu.
   - Fill in the member details and click "Save."

2. **View Members**:
   - Open the "Members" page to see the list of all registered members.

3. **Log Attendance**:
   - Navigate to the "Sign In Log" page.
   - Enter the member’s ID, name, and sign-in time, then click "Sign In."

4. **Search Attendance**:
   - Use the search bar on the "Sign In Log" page to filter records by name or date.