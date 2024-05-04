# ICS Scheduling System

The ICS Scheduling System is a comprehensive platform designed to modernize and optimize the scheduling process for students, instructors, and administrative staff at Colegio De Montalban's Institute of Computer Studies.

## Features:

### Admin Tools:
- Optimizing scheduling tasks
- Assign instructors to classes
- Generate reports for efficient management
- Add Instructors

### Viewing Website:
- Access schedules conveniently
- User-friendly interface for easy navigation

## Necessary Devices:
- RFID Reader for enhanced security and efficiency

## Database Setup:
- Database Name: ics_scheduling_db
- Customizable database connection available in the DatabaseConnection.vb file

## Database Tables

### instructor
- **Description**: Store information about instructors
- **Fields**: 
    - InstructorID (INT): Unique identifier for each instructor
    - RFID (VARCHAR(255)): RFID code for identification
    - Firstname (VARCHAR(255)): First name of the instructor
    - MiddleName (VARCHAR(255)): Middle name of the instructor
    - Surname (VARCHAR(255)): Last name of the instructor
    - Position (VARCHAR(255)): Position or title of the instructor
    - WorkStatus (VARCHAR(255)): Current work status of the instructor
    - email (VARCHAR(255)): Email address of the instructor
- **Constraints**: 
    - Unique constraint on RFID: `instructor_rfid_unique`
    - Unique constraint on email: `instructor_email_unique`

### sections
- **Description**: Manage sections with section code, year, and program details
- **Fields**:
    - SectionID (INT): Unique identifier for each section
    - Section_Code (VARCHAR(255)): Code representing the section
    - Year (VARCHAR(255)): Year of the section
    - Section_Program (VARCHAR(255)): Program associated with the section

### rooms
- **Description**: Maintain information about rooms available for scheduling
- **Fields**:
    - RoomID (INT): Unique identifier for each room
    - Room (VARCHAR(255)): Name or identifier of the room

### schedules
- **Description**: Schedule classes with details such as instructor name, section, subject, start time, end time, day, and room number
- **Fields**:
    - ScheduleID (INT): Unique identifier for each schedule entry
    - InstructorName (VARCHAR(255)): Name of the instructor teaching the class
    - Section (VARCHAR(255)): Section associated with the class
    - Subject (VARCHAR(255)): Subject of the class
    - StartTime (TIME): Start time of the class
    - EndTime (TIME): End time of the class
    - Day (VARCHAR(255)): Day of the week the class occurs
    - RoomNumber (VARCHAR(255)): Room number where the class is held

### subjects
- **Description**: Store subjects along with their descriptions and codes
- **Fields**:
    - SubjectID (INT): Unique identifier for each subject
    - subject_description (VARCHAR(255)): Description of the subject
    - subject-code (VARCHAR(255)): Code representing the subject
- **Constraints**: 
    - Unique constraint on subject_description: `subjects_subject_description_unique`
      
### License
This project is licensed under the [MIT License](LICENSE).

Thank you for choosing the ICS Scheduling System.
