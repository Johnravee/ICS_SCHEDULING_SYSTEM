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

## Tables in Database:
CREATE TABLE `instructor`(
    `InstructorID` INT NOT NULL AUTO_INCREMENT PRIMARY KEY,
    `RFID` VARCHAR(255) NOT NULL,
    `Firstname` VARCHAR(255) NOT NULL,
    `MiddleName` VARCHAR(255) NOT NULL,
    `Surname` VARCHAR(255) NOT NULL,
    `Position` VARCHAR(255) NOT NULL,
    `WorkStatus` VARCHAR(255) NOT NULL,
    `email` VARCHAR(255) NOT NULL
);
ALTER TABLE
    `instructor` ADD UNIQUE `instructor_rfid_unique`(`RFID`);
ALTER TABLE
    `instructor` ADD UNIQUE `instructor_email_unique`(`email`);
CREATE TABLE `sections`(
    `SectionID` INT NOT NULL AUTO_INCREMENT PRIMARY KEY,
    `Section_Code` VARCHAR(255) NOT NULL,
    `Year` VARCHAR(255) NOT NULL,
    `Section_Program` VARCHAR(255) NOT NULL
);
CREATE TABLE `rooms`(
    `RoomID` INT NOT NULL AUTO_INCREMENT PRIMARY KEY,
    `Room` VARCHAR(255) NOT NULL
);
CREATE TABLE `schedules`(
    `ScheduleID` INT NOT NULL AUTO_INCREMENT PRIMARY KEY,
    `InstructorName` VARCHAR(255) NOT NULL,
    `Section` VARCHAR(255) NOT NULL,
    `Subject` VARCHAR(255) NOT NULL,
    `StartTime` TIME NOT NULL,
    `EndTime` TIME NOT NULL,
    `Day` VARCHAR(255) NOT NULL,
    `RoomNumber` VARCHAR(255) NOT NULL
);
CREATE TABLE `subjects`(
    `SubjectID` INT NOT NULL AUTO_INCREMENT PRIMARY KEY,
    `subject_description` VARCHAR(255) NOT NULL,
    `subject-code` VARCHAR(255) NOT NULL
);
ALTER TABLE
    `subjects` ADD UNIQUE `subjects_subject_description_unique`(`subject_description`);



### instructor:
- Store information about instructors

### sections:
- Manage sections with section code, year, and program details

### rooms:
- Maintain information about rooms available for scheduling

### schedules:
- Schedule classes with details such as instructor name, section, subject, start time, end time, day, and room number

### subjects:
- Store subjects along with their descriptions and codes.



Thank you for choosing the ICS Scheduling System.
