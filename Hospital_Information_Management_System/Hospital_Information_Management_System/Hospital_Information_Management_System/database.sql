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

drop TABLE records;
CREATE TABLE records(
mid INT NOT NULL,
patientname VARCHAR(100) NOT NULL,
doctorname VARCHAR(100),
nurse VARCHAR(100),
diagnosis VARCHAR(100),
prescription VARCHAR(100),
treatment VARCHAR(100),
PRIMARY KEY(mid)

);
drop TABLE bills;
CREATE TABLE bills(
bid INT NOT NULL,
patientname VARCHAR(100) NOT NULL,
amount DECIMAL(10,2),
status VARCHAR(100),
PRIMARY KEY(bid)

);

CREATE TABLE appointments(
aid INT NOT NULL,
patientname VARCHAR(100) NOT NULL,
doctorname VARCHAR(100),
date_created DATE,
status VARCHAR(100),
PRIMARY KEY(aid)

);

