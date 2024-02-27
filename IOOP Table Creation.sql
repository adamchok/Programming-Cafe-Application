create table Module (
	ModuleCode nvarchar(10) NOT NULL PRIMARY KEY,
	ModuleName nvarchar(10) NOT NULL,
	Level nchar(12) NOT NULL,
	Fee decimal NOT NULL
);

create table Admin (
	AdminID nchar(8) NOT NULL PRIMARY KEY,
	Name nvarchar(50) NOT NULL,
	ContactNumber nchar(12) NOT NULL,
	Email nvarchar(50) NOT NULL,
	Address nvarchar(MAX) NOT NULL
);

create table Lecturer (
	LecturerID nchar(8) NOT NULL PRIMARY KEY,
	Name nvarchar(50) NOT NULL,
	ContactNumber nchar(12) NOT NULL,
	Email nvarchar(50) NOT NULL,
	Address nvarchar(MAX) NOT NULL
);

create table Student (
	StudentID nchar(8) NOT NULL PRIMARY KEY,
	Name nvarchar(50) NOT NULL,
	ContactNumber nchar(12) NOT NULL,
	Email nvarchar(50) NOT NULL,
	Address nvarchar(MAX) NOT NULL
);

create table Trainer (
	TrainerID nchar(8) NOT NULL PRIMARY KEY,
	Name nvarchar(50) NOT NULL,
	ContactNumber nchar(12) NOT NULL,
	Email nvarchar(50) NOT NULL,
	Address nvarchar(MAX) NOT NULL
);

create table Login (
	Username nchar(8) NOT NULL PRIMARY KEY,
	Password nvarchar(30) NOT NULL,
	UserRole nchar(8) NOT NULL
);

create table Trainer_Module (
	TrainerID nchar(8) NOT NULL,
    ModuleCode nvarchar(10) NOT NULL,
    CONSTRAINT PK_Trainer_Module PRIMARY KEY (TrainerID, ModuleCode),
	CONSTRAINT FK_Trainer_Module_TrainerID FOREIGN KEY (TrainerID) REFERENCES Trainer(TrainerID) ON DELETE CASCADE,
    CONSTRAINT FK_Trainer_Module_ModuleCode FOREIGN KEY (ModuleCode) REFERENCES Module(ModuleCode)
);

create table Class (
	ClassCode nvarchar(12) NOT NULL,
	TrainerID nchar(8) NOT NULL,
	ModuleCode nvarchar(10) NOT NULL,
	Intake nchar(6) NOT NULL,
	TimeSchedule nvarchar(30) NOT NULL,
	Day nchar(10) NOT NULL,
	Venue nchar(5) NOT NULL,
	CONSTRAINT PK_Class_Module PRIMARY KEY (ClassCode, TrainerID, TimeSchedule, Venue, Day),
	CONSTRAINT FK_Class_TrainerID FOREIGN KEY (TrainerID, ModuleCode) REFERENCES Trainer_Module(TrainerID, ModuleCode) ON DELETE CASCADE
);

create table MonthlyIncomeReport (
	ReportID int IDENTITY(1,1) NOT NULL PRIMARY KEY,
	TrainerID nchar(8) NOT NULL,
	ModuleCode nvarchar(10) NOT NULL,
	ReportMonth nchar(12) NOT NULL,
	ReportYear nchar(4) NOT NULL,
	Income money NOT NULL,
	CONSTRAINT FK_MonthlyIncomeReport_TrainerID FOREIGN KEY (TrainerID, ModuleCode) REFERENCES Trainer_Module(TrainerID, ModuleCode) ON DELETE CASCADE
);

create table Feedback (
	FeedbackID int IDENTITY(1,1) NOT NULL PRIMARY KEY,
	TrainerID nchar(8) NOT NULL,
	ModuleCode nvarchar(10) NOT NULL,
	Message nvarchar(MAX) NOT NULL,
	FeedbackType nchar(10) NOT NULL
	CONSTRAINT FK_Feedback_TrainerID FOREIGN KEY (TrainerID, ModuleCode) REFERENCES Trainer_Module(TrainerID, ModuleCode) ON DELETE CASCADE
);

create table Enrolment (
	EnrolmentID int IDENTITY(1,1) NOT NULL,
	StudentID nchar(8) NOT NULL,
	ClassCode nvarchar(12) NULL,
	ModuleCode nvarchar(10) NOT NULL,
	Intake nchar(6) NOT NULL, 
	TrainerID nchar(8) NULL,
	PRIMARY KEY (StudentID, ModuleCode),
	CONSTRAINT FK_Enrolemt_TrainerID FOREIGN KEY (TrainerID, ModuleCode) REFERENCES Trainer_Module(TrainerID, ModuleCode),
	CONSTRAINT FK_Enrolment_StudentID FOREIGN KEY (StudentID) REFERENCES Student(StudentID) ON DELETE CASCADE
);

CREATE TABLE Payment (
    PaymentID INT IDENTITY(1,1) NOT NULL,
    StudentID NCHAR(8) NOT NULL,
    ModuleCode NVARCHAR(10) NOT NULL,
	Intake nchar(6) NOT NULL,
    PaymentMonth NCHAR(12) NOT NULL,
    PaymentAmount MONEY NOT NULL,
    PaymentDate DATE NULL,
    InvoiceNumber NVARCHAR(16) NULL,
    Validated NCHAR(3) NOT NULL,
	CONSTRAINT PK_Payment PRIMARY KEY (StudentID, ModuleCode, PaymentMonth), 
    CONSTRAINT FK_Payment_Enrolment FOREIGN KEY (StudentID, ModuleCode) REFERENCES Enrolment(StudentID, ModuleCode) ON DELETE CASCADE ON UPDATE CASCADE
);


CREATE TABLE Request (
	RequestID int IDENTITY(1,1) NOT NULL PRIMARY KEY,
	StudentID nchar(8) NOT NULL,
	ModuleCode nvarchar(10) NOT NULL,
	CONSTRAINT FK_Request_StudentID FOREIGN KEY (StudentID) REFERENCES Student(StudentID) ON DELETE CASCADE,
	CONSTRAINT FK_Request_ModuleCode FOREIGN KEY (ModuleCode) REFERENCES Module(ModuleCode)
);