create table Students (
    StudentId int identity(1,1) primary key,
    FullName varchar(100) NOT NULL,
    Email varchar(100) unique,
    Department varchar(50) NOT NULL,
    YearOfStudy int NOT NULL
);
select * from Students

insert into Students (FullName, Email, Department, YearOfStudy) values
('Ajay', 'ajay@gmail.com', 'CSC', 4),
('Vijay', 'vijay@gmail.com', 'MEC', 1),
('Manideep', 'mani@gmail.com', 'ECE', 2),
('Navadeep', 'nava@gmail.com.com', 'EEE', 3),
('Sasi', 'sasi@gmail.com', 'BIO', 3);

create table Courses (
    CourseId int identity(1,1) primary key,
    CourseName varchar(100) NOT NULL,
    Credits int NOT NULL,
    Semester varchar(20) NOT NULL
);
insert into Courses (CourseName, Credits, Semester) values
('Data Structures', 4, 'Fall'),
('ADCS', 3, 'Spring'),
('Organic Chemistry', 4, 'Fall'),
('Physics ', 3, 'Spring'),
('Biology', 3, 'Fall'),
('Computer Networks', 3, 'Spring');
select * from Courses


create table Enrollments (
    EnrollmentId int identity(1,1) primary key,
    StudentId int NOT NULL,
    CourseId int NOT NULL,
    EnrollDate datetime NOT NULL,
    Grade varchar(5) NULL,
    constraint FK_Enrollments_Students foreign key (StudentId)
        references Students(StudentId),
    constraint FK_Enrollments_Courses foreign key (CourseId)
        references Courses(CourseId)
);
select * from Enrollments
insert into Enrollments (StudentId, CourseId, EnrollDate, Grade) values
(1, 1, '2025-12-01 10:00', 'A'),
(1, 6, '2025-12-02 11:00', 'B+'),
(2, 2, '2025-12-03 09:30', 'A-'),
(3, 4, '2025-12-04 14:00', 'B'),
(4, 3, '2025-12-05 08:45', 'C+'),
(5, 5, '2025-12-06 12:15', 'B-');




select * from Students
select * from Courses
select * from Enrollments


create procedure usp_GetCoursesBySemester
    @semester varchar(20)
as
begin
    select CourseId, CourseName, Credits, Semester
    from Courses
    where Semester = @semester;
end
