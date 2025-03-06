CREATE DATABASE HospitalDB;

USE HospitalDB;
CREATE TABLE patients(
patientid INT NOT NULL,
patientname VARCHAR(100) NOT NULL,
age INT,
gender VARCHAR(100),
address VARCHAR(100),
PRIMARY KEY(patientid)

);

drop TABLE doctors;

CREATE TABLE doctors(
doctorid INT NOT NULL,
doctorname VARCHAR(100) NOT NULL,
speciality VARCHAR(100),
phone VARCHAR(100),
department VARCHAR(100),
PRIMARY KEY(doctorid)

);



drop TABLE doctors;



CREATE TABLE doctors(
doctorid INT NOT NULL,
doctorname VARCHAR(100) NOT NULL,
speciality VARCHAR(100),
phone VARCHAR(100),
department VARCHAR(100),
PRIMARY KEY(doctorid)

);





CREATE TABLE nurses(
nurseid INT NOT NULL,
nursename VARCHAR(100) NOT NULL,
phone VARCHAR(100),
department VARCHAR(100),
PRIMARY KEY(nurseid)

);