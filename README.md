![Alt text](https://github.com/wesleykarle/4ALL/blob/master/Logo%20(4ALL).jpg "Logo")


# Contents  
- [Description](#description)  

- [Requirements](#requirements) 

- [ERD](#erd) 

- [Wireframes](#wireframes)

- [Prototypes](#prototypes) 

- [Database](#database)

- [TODO](#todo)

<a name="desciption"/>
<a name="requirements"/>
<a name="erd"/>
<a name="wireframes"/>
<a name="prototypes"/>
<a name="database"/>
<a name="todo"/>

# Description
4ALL is a vision of mine that would create a new, easier alternative to locate and sign up for volunteering opportunities in your local community and beyond. Users and Organizations will be able to easily connect on a social media backed framework solely intended to serve others. Users will be able to track their community service hours and build their profiles to use for a multitude of reasons including Academically, Professionally, and Spiritually. 


# Requirements
![Alt text](https://github.com/wesleykarle/4ALL/blob/master/Documents/RTM.png)


# ERD
![Alt text](https://github.com/wesleykarle/4ALL/blob/master/Documents/Entity%20Relationship%20Diagram%20(ERD).png)


# Wireframes
*Profile View*
![Alt text](https://github.com/wesleykarle/4ALL/blob/master/Logon%20Page.PNG)

*Sign Up Page*
![Alt text](https://github.com/wesleykarle/4ALL/blob/master/Sign%20Up%20Page.PNG)


# Prototypes
[Mock Pages](https://github.com/wesleykarle/4ALL/tree/master/Mock%20Pages)


# Database 
use [4ALL];
drop table if exists dbo.Users;
create table dbo.Users
(
UserName VARCHAR(20) NOT NULL,
PRIMARY KEY (UserName),
FirstName VARCHAR(40) NOT NULL,
LastName VARCHAR(40) NOT NULL,
Age INT NOT NULL,
City VARCHAR(40) NOT NULL,
State VARCHAR(40) NOT NULL,
Country VARCHAR(40) NOT NULL,
PhoneNumber VARCHAR(20) NOT NULL,
Email VARCHAR(40) NOT NULL
);
INSERT INTO dbo.Users(UserName, FirstName, LastName, Age, City, State, Country, PhoneNumber, Email)
VALUES
('BillySD', 'Billy', 'Bailey', 25, 'San Diego', 'California', 'USA', '(721) 928-3857', 'billytest@outlook.com'),
('mandyp', 'Mandy', 'Cobb', 21, 'Los Angeles', 'California', 'USA', '(354) 260-1400', 'mandymandy@gmail.com'),
('KhRocks', 'Kevin', 'Hill', 19, 'Seattle', 'Washington', 'USA', '(933) 732-2353', 'kt19@yahoo.com'),
('Nat28M', 'Natalie', 'Mckinney', 28, 'Huntington', 'New York', 'USA', '(973) 672-3345', 'lstaf@me.com'),
('ShawnKlein01', 'Shawn', 'Klein', 18, 'Riverside', 'California', 'USA', '(674) 774-3238', 'fbriere@me.com'),
('CarterA', 'Amy', 'Carter', 31, 'Orlando', 'Florida', 'USA', '(601) 538-6279', 'odlyzko@att.net'),
('LittleLouis', 'Max', 'Little', 27, 'St. Louis', 'Missouri', 'USA', '(351) 269-5559', 'seebs@att.net'),
('BRita97', 'Rita', 'Boyd', 21, 'Lincoln', 'Nebraska', 'USA', '(324) 846-4509', 'chlim@comcast.net'),
('SantossC', 'Clark', 'Santos', 29, 'Fort Wayne', 'Indiana', 'USA', '(735) 568-8145', 'rgarton@hotmail.com'),
('AJennAZ', 'Alexander', 'Jennings', 25, 'Tucson', 'Arizona', 'USA', '(583) 821-6901', 'jsnover@icloud.com');
--===============================================================================================================
USE [4ALL];
drop table if exists dbo.Organizations;
CREATE TABLE Organizations 
(
OrganizationName varchar(255) NOT NULL,
PRIMARY KEY (OrganizationName),
City varchar(255) NOT NULL,
State varchar(255) NOT NULL,
Country varchar(255) NOT NULL
);
INSERT INTO dbo.Organizations(OrganizationName, City, State, Country)
VALUES
('Cat Center USA','Albuquerque', 'New Mexico', 'USA'),
('New York City Police Department', 'New York', 'New York', 'USA'),
('City of Oceanside Library','Oceanside', 'California', 'USA'),
('YMCA of the USA', 'Chicago', 'Illinois', 'USA'),
('United Way Worldwide', 'Alexandria', 'Virginia', 'USA'),
('Feeding America','Chicago', 'Illinois', 'USA'),
('Salvation Army', 'Alexandria', 'Virginia', 'USA'),
('Boys & Girls Club of America', 'Atlanta', 'Georgia', 'USA'),
('Save the Children Federation', 'Fairfield', 'Connecticut', 'USA'),
('Habitat for Humanity International', 'Americus', 'Georgia', 'USA');
--===============================================================================================================
USE [4ALL];
drop table if exists dbo.Events;
CREATE TABLE Events
(
OrganizationName varchar(255) NOT NULL,
PRIMARY KEY (OrganizationName),
EventName varchar(255) NOT NULL,
EventDate varchar(255) NOT NULL,
NumberOfOpenings INT NOT NULL,
HrsAvailable INT NOT NULL,
Address varchar(255) NOT NULL,
City varchar(255) NOT NULL,
State varchar(255) NOT NULL,
Country varchar(255) NOT NULL,
PhoneNumer varchar(255) NOT NULL,
Email varchar(255) NOT NULL
);
INSERT INTO dbo.Events(OrganizationName, EventName, EventDate, NumberOfOpenings, HrsAvailable, Address,
						City, State, Country, PhoneNumer, Email)
VALUES
('Cat Center USA', 'Feed The Cats', '17 Aug 2019', 10, 2, '91665 Desert Dr', 'Albuquerque', 'New Mexico', 'USA','(451) 921- 5578', 'catsrule@gmail.com'),
('New York City Police Department', 'Pops For Cops', '01 Sep 2019', 50, 3, '12 West Blvd', 'New York', 'New York', 'USA', '(711) 123, 813', 'nynycity@yahoo.com'),
('City of Oceanside Library', 'Tutoring', '05 Aug 2019 - 09 Aug 2019', 2, 5, '330 N Coast Hwy', 'Oceanside', 'California', 'USA', '(760) 123-1234', 'olibrary@mail.mail');
--===============================================================================================================
USE [4ALL];
drop table if exists dbo.Hours;
CREATE TABLE Hours
(
UserName varchar(20) NOT NULL,
PRIMARY KEY (UserName),
TotalHours INT,
FOREIGN KEY (UserName) REFERENCES Users (UserName)
);
INSERT INTO dbo.Hours(UserName, TotalHours)
VALUES
('BillySD', NULL),
('mandyp', 8),
('KhRocks', 1),
('Nat28M', 60),
('ShawnKlein01', 4),
('CarterA', 2),
('LittleLouis', 55),
('BRita97', 35),
('SantossC', 3),
('AJennAZ', 17);
--===============================================================================================================
use [4ALL];
drop table if exists dbo.Badges;
CREATE TABLE Badges
(
BadgeName varchar(10) NOT NULL,
Criteria varchar(255) NOT NULL,
[Number Issued] INT NOT NULL,
FilePath varchar(255) NOT NULL,
Issuer varchar(10) NOT NULL
);
INSERT INTO dbo.Badges(BadgeName, Criteria, [Number Issued], FilePath, Issuer)
VALUES
('Giver', '5 Hours or Less', 1, 'http://easyanimatorpro.com/wp-content/uploads/igloo/679/images/user/meaj0erkkykocyjdgohl.png', '4ALL'),
('Supporter', '10 Hours or Less', 1, 'http://easyanimatorpro.com/wp-content/uploads/igloo/679/images/user/meaj0erkkykocyjdgohl.png', '4ALL'),
('Believer', '20 Hours or Less', 1, 'http://easyanimatorpro.com/wp-content/uploads/igloo/679/images/user/meaj0erkkykocyjdgohl.png', '4ALL'),
('Devoted', '50 Hours or Less', 2, 'http://easyanimatorpro.com/wp-content/uploads/igloo/679/images/user/meaj0erkkykocyjdgohl.png', '4ALL');
--===============================================================================================================
USE [4ALL];
drop table if exists dbo.UserBadges;
CREATE TABLE UserBadges
(
PRIMARY KEY (UserName,BadgeName),
UserName varchar(20) NOT NULL,
BadgeName varchar(10) NOT NULL,
LinkedUrls varchar(255),
FOREIGN KEY (UserName) REFERENCES Users (UserName)
);
INSERT INTO dbo.UserBadges(UserName, BadgeName, LinkedUrls)
VALUES
('Nat28M', 'Devoted', 'https://linkedin.com/test1'),
('AJennAZ', 'Giver', NULL),
('mandyp', 'Supporter', 'https://linkedin.com/test2'),
('LittleLouis', 'Devoted', 'https://facebook.com/test3'),
('BRita97', 'Believer', NULL);


# TODO
1. Expand personal and opportunities feeds for profile page
2. Implement database 
3. Create views for organizations

[Table of Contents](#contents)
<a name="contents"/>
