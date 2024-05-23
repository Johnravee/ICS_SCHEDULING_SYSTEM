# ICS Scheduling System

The ICS Scheduling System is a comprehensive platform designed to modernize and optimize the scheduling process for students, instructors, and administrative staff at Colegio De Montalban's Institute of Computer Studies.

## Features:

### Admin Tools:
- ⚙️ Optimizing scheduling tasks
- 👩‍🏫 Assign instructors to classes
- 📊 Generate reports for efficient management
- ➕ Add Instructors

### Viewing Website:
- 🖥️ Access schedules conveniently
- 🌐 User-friendly interface for easy navigation

## Necessary Devices:
- 📟 RFID Reader for enhanced security and efficiency

## Database Setup:
- **Database Name**: ics_scheduling_db
- Customizable database connection available in the DatabaseConnection.vb file

## Database Tables

### `instructor` Table
- **Description**: Store information about instructors
- **Fields**: 
    - InstructorID (INT): Unique identifier for each instructor
    - RFID (VARCHAR(255)): RFID code for identification
    - Firstname (VARCHAR(100)): First name of the instructor
    - MiddleName (VARCHAR(100)): Middle name of the instructor
    - Surname (VARCHAR(100)): Last name of the instructor
    - Gender (VARCHAR(10)): Gender of the instructor
    - Position (VARCHAR(50)): Position or title of the instructor
    - WorkStatus (VARCHAR(20)): Current work status of the instructor
    - email (VARCHAR(255)): Email address of the instructor
- **Constraints**: 
    - Unique constraint on RFID: `instructor_rfid_unique`
    - Unique constraint on email: `instructor_email_unique`

### `sections` Table
- **Description**: Manage sections with section code, year, and program details
- **Fields**:
    - SectionID (INT): Unique identifier for each section
    - Section_Program (VARCHAR(20)): Program associated with the section
    - Year (VARCHAR(20)): Year of the section
    - Section_Code (VARCHAR(20)): Code representing the section

### `rooms` Table
- **Description**: Maintain information about rooms available for scheduling
- **Fields**:
    - RoomID (INT): Unique identifier for each room
    - Room (VARCHAR(100)): Name or identifier of the room

### `schedules` Table
- **Description**: Schedule classes with details such as instructor name, section, subject, start time, end time, day, and room number
- **Fields**:
    - ScheduleID (INT): Unique identifier for each schedule entry
    - InstructorName (VARCHAR(100)): Name of the instructor teaching the class
    - Section (VARCHAR(50)): Section associated with the class
    - Subject (VARCHAR(50)): Subject of the class
    - StartTime (TIME): Start time of the class
    - EndTime (TIME): End time of the class
    - Day (VARCHAR(50)): Day of the week the class occurs
    - RoomNumber (VARCHAR(50)): Room number where the class is held
    - Semester (VARCHAR(50)) : Semester of current schedule
    - Duration (VARCHAR(20)): Duration of the class

### `subjects` Table
- **Description**: Store subjects along with their descriptions and codes
- **Fields**:
    - SubjectID (INT): Unique identifier for each subject
    - subject_description (VARCHAR(50)): Description of the subject
    - subject_code (VARCHAR(50)): Code representing the subject
- **Constraints**: 
    - Unique constraint on subject_description: `subjects_subject_name_unique`
    - Unique constraint on subject_code: `subjects_subject_code_unique`

## License
This project is licensed under the [MIT License](LICENSE).

Thank you for choosing the ICS Scheduling System.
