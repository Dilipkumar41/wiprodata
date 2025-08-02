CREATE table DOCTOR_MASTER
(
    doctor_id VARCHAR(15) PRIMARY KEY,      
    doctor_name VARCHAR(15) NOT NULL,
    dept VARCHAR(15) NOT NULL
)
Go

-- Inserting data into table

Insert into DOCTOR_MASTER(doctor_id,doctor_name,dept)
values('D0001','Ram','ENT'),
('D0002','Rajan','ENT'),
('D0003','Smita','Eye'),
('D0004','Bhavan','Surgery'),
('D0005','Sheela','Surgery'),
('D0006','Nethra','Surgery')

-- Creating Room_master

create table ROOM_MASTER
(
	room_no varchar(15) Primary Key,
	room_type varchar(15) not null,
	status varchar(15) not null
)
Go

--Insertinng data into the Room_master\

Insert into ROOM_MASTER(room_no,room_type,status)
values('R0001','AC','occupied'),
('R0002','Suite','vacant'),
('R0003','NonAC','vacant'),
('R0004','NonAC','occupied'),
('R0005','AC','vacant'),
('R0006','AC','occupied')
Go

CREATE TABLE PATIENT_MASTER (
    pid        VARCHAR(15) PRIMARY KEY,        -- Unique and NOT NULL
    name       VARCHAR(15) NOT NULL,
    age        NUMERIC(15) NOT NULL,
    weight     NUMERIC(15) NOT NULL,
    gender     VARCHAR(10) NOT NULL,
    address    VARCHAR(50) NOT NULL,
    phoneno    VARCHAR(10) NOT NULL,
    disease    VARCHAR(50) NOT NULL,
    doctor_id  VARCHAR(15) NOT NULL,
    
    FOREIGN KEY (doctor_id) REFERENCES DOCTOR_MASTER(doctor_id)
)
Go

--Insering values into patient Master
INSERT INTO PATIENT_MASTER (pid, name, age, weight, gender, address, phoneno, disease, doctor_id)
VALUES 
('P0001', 'Gita',     35, 65, 'F', 'Chennai',   '9867145678', 'Eye Infection',    'D0003'),
('P0002', 'Ashish',   40, 70, 'M', 'Delhi',     '9845675678', 'Asthma',           'D0003'),
('P0003', 'Radha',    25, 60, 'F', 'Chennai',   '9867166678', 'Pain in heart',    'D0005'),
('P0004', 'Chandra',  28, 55, 'F', 'Bangalore', '9978675567', 'Asthma',           'D0001'),
('P0005', 'Goyal',    42, 65, 'M', 'Delhi',     '8967533223', 'Pain in Stomach',  'D0004')
Go

---creating table
CREATE TABLE ROOM_ALLOCATION
(
    room_no VARCHAR(15), 
    pid VARCHAR(15),                      
    admission_date DATE NOT NULL,        
    release_date DATE,                   

    -- Optional: Add foreign key constraints if tables exist
    FOREIGN KEY (room_no) REFERENCES ROOM_MASTER(room_no),
    FOREIGN KEY (pid) REFERENCES PATIENT_MASTER(pid)
)
Go

INSERT INTO ROOM_ALLOCATION (room_no, pid, admission_date, release_date)
VALUES ('R0001', 'P0001','15-oct-2016', '26-OCT-2016'),
('R0002','P0002','15-nov-16','26-nov-16'),
('R0003','P0003','01-dec-16','26-nov-16'),
('R0004','P0001','01-jan-17','30-jan-17')
Go


-- Displaying the patient who where adimitted in the month of january
SELECT * 
FROM ROOM_ALLOCATION
WHERE MONTH(admission_date) = 1;
Go

-- Selecting female patients who is not suffering from asthma

SELECT * 
FROM PATIENT_MASTER
WHERE gender = 'F' AND LOWER(disease) != 'Asthma'
Go

-- selecting male and female patients
SELECT gender, COUNT(*) As Patient_count
FROM PATIENT_MASTER
GROUP BY gender
Go

---selecting the room which is not allocated bby any patient
SELECT room_no 
FROM ROOM_MASTER
WHERE room_no NOT IN (SELECT room_no FROM ROOM_ALLOCATION)
Go
