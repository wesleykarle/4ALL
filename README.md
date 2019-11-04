![Alt text](https://github.com/wesleykarle/4ALL/blob/master/Logo%20(4ALL).jpg "Logo")


# Contents  
- [Description](#description)  

- [Requirements](#requirements) 

- [ERD](#erd) 

- [Diagram](#diagram)

- [Wireframes](#wireframes)

- [Prototypes](#prototypes) 

- [Database](#database)

- [Sprint](#sprint)

<a name="desciption"/>
<a name="requirements"/>
<a name="erd"/>
<a name="wireframes"/>
<a name="prototypes"/>
<a name="database"/>
<a name="sprint">

# Description
4ALL is a vision of mine that would create a new, easier alternative to locate and sign up for volunteering opportunities in your local community and beyond. Users and Organizations will be able to easily connect on a social media backed framework solely intended to serve others. Users will be able to track their community service hours and build their profiles to use for a multitude of reasons including Academically, Professionally, and Spiritually. 


# Requirements

### Entrance Requirements

|   __ID__    |                             __Description__                             | __Test Method__ |
|-------------|-------------------------------------------------------------------------|-----------------|
| 1           | User successfully accesses website                                      | Inspection      |
| 1.1         | User creates new account                                                | Demonstration   |
| 1.2         | User Loggs in/ Accesses personal account                                | Demonstration   |
| 2           | Correct Email renders for signed in user                                | Inspection      |
| 2.1         | Links inside main dropdown navigate the user correctly                  | Test            |
| 2.2         | User successfully signs out of account                                  | Test            |
| 2.3         | Pages scale for mobile use                                              | Inspection      |
| 3           | User can upload picture or input text for post                          | Demonstration   |
| 3.1         | User selects specific criteria for volunteer opportunity                | Demonstration   |
| 4           | Post to personal feed                                                   | Inspection      |
| 4.1         | User Submits volunteer submission, sending information to their history | Inspection      |

### Traceability
| __ID__  |       __1__         |          __2__        |         __3__         |      __4__          |
|---------|---------------------|-----------------------|-----------------------|---------------------|
| 1       | :heavy_check_mark:  |                       |                       |                     |
| 1.1     | :heavy_check_mark:  |                       |                       |                     |
| 1.2     | :heavy_check_mark:  |                       |                       |                     |
| 2       |                     | :heavy_check_mark:    |                       |                     |
| 2.1     |                     | :heavy_check_mark:    |                       |                     |
| 2.2     |                     | :heavy_check_mark:    |                       |                     |
| 2.3     |                     | :heavy_check_mark:    |                       |                     |
| 3       |                     |                       | :heavy_check_mark:    |                     |
| 3.1     |                     |                       | :heavy_check_mark:    |                     |
| 4       |                     |                       | :heavy_check_mark:    | :x:                 |
| 4.1     |                     |                       | :heavy_check_mark:    | :x:                 |
Test Casses traced to a test case: 100%


### Exit Criteria

| __ID__  |                           __Test Procedure__                       | __Req__ | __Status__  | __Date__    | 
|---------|--------------------------------------------------------------------|---------|-------------|-------------|
| 1       | Enter correct URL: https://4allwebapp.azurewebsites.net/           | 1       | Passed      | 2019-11-03  |
| 1.1     | User navigates to Sign Up tab after ID 1                           | 1       | Passed      | 2019-11-03  |
| 1.2     | User Clicks Profile tab after sign up                              | 1,1.1   | Passed      | 2019-11-03  |
| 2       | Navigate to profile and view email listed below picture            | 1 - 1.2 | Passed      | 2019-11-03  |
| 2.1     | Click dropdown next to meu on profile                              | 1, 2    | Passed      | 2019-11-03  |
| 2.2     | Menu dropdown --> Setting --> Sign Out                             | 1 - 2   | Passed      | 2019-11-03  |
| 2.3     | Mobile phone, enter url listed in ID 1                             | 1 - 2   | Passed      | 2019-11-03  |
| 3       | Post --> Choose Files                                              | 1 - 3   | Passed      | 2019-11-03  |
| 3.1     | Volunteer with Button --> Choose: Hours, Date, Location            | 1 - 3.1 | Passed      | 2019-11-03  |
| 4       | Post --> Choose Files --> Post                                     | 3, 4    | Failed      | 2019-11-03  |
| 4.1     | Volunteer with Button --> Choose: Hours, Date, Location --> Submit | 3, 4    | Failed      | 2019-11-03  |
Test Casses passing: 81%

###### Review Findings:
- Layout of some buttons/ text positionally instead of size.
- Page renders back to the top after hitting settings the first time, but not after.

# ERD
![Alt text](https://github.com/wesleykarle/4ALL/blob/master/Documents/Entity%20Relationship%20Diagram%20(ERD).png)


# Diagram
![Alt text](https://github.com/wesleykarle/4ALL/blob/master/Documents/Database%20Diagram.png)


# Wireframes
*Profile View*
![Alt text](https://github.com/wesleykarle/4ALL/blob/master/Wireframes/Logon%20Page.PNG)

*Sign Up Page*
![Alt text](https://github.com/wesleykarle/4ALL/blob/master/Wireframes/Sign%20Up%20Page.PNG)


# Prototypes
## Home Page
- For the homepage I wanted to keep it clean and minimal, offering exactly what is needed and important to the site. Three buttons up top take you to the respective pages listed. The sign-in button is a dropdown that allows users to log in straight from the home page without navigating to another page.
![Alt text](https://github.com/wesleykarle/4ALL/blob/master/Mock%20Pages/Home.png)  
## Sign Up Page
- The sign-up page has three parts of functionality (other social media verification) that still needs to be incorporated. I still wanted to offer prospective users the ability to sign up the old fashion way, so we have a form to take all pertinent information for the website. 
![Alt text](https://github.com/wesleykarle/4ALL/blob/master/Mock%20Pages/Sign%20Up.png)
## About Page
- I wanted the about page to offer a clear and concise description of what 4ALL is, the page includes a clean layout with a descriptive paragraph and three buttons along the top portion of the page. Buttons navigate users back to respective parts of the website. Near the bottom, I thought a carousel showcasing what 4ALL is promoting was appropriate to give a nice visual to users. 
![Alt text](https://github.com/wesleykarle/4ALL/blob/master/Mock%20Pages/About.png)
## Contact Page
- On the contact page, you will see the standard buttons to aid in navigating the site. Along with a text box at the bottom to take input and feedback from users when they encounter an issue. 
![Alt text](https://github.com/wesleykarle/4ALL/blob/master/Mock%20Pages/Contact.png)
## Profile Page
- The mock profile page will see many changes from this demo. The end goal is to have a clean layout that displays all pertinent information for the user along the top next to their profile pictures. There you will see the username, location, and level bar showcasing the level and badge the user has obtained through their commitment to service. Also provided is a search bar to allow searches for other users or organizations. And finally the two portions that are currently being developed are the personal feed, and future opportunities feed. The goal is to have them both be static infinite scrolling boxes that showcase connections pictures posts and comments, along with an easy one-click way to sign up for volunteering opportunities as they show up on the feed. 
![Alt text](https://github.com/wesleykarle/4ALL/blob/master/Mock%20Pages/Updated%20Profile.png)
## Badge Criteria Page
- The badge criteria page is provided for all users to fully understand how to pursue and obtain different badges through 4ALL. Users will navigate to this page by clicking the current badge name on any profile, including their own.  
![Alt text](https://github.com/wesleykarle/4ALL/blob/master/Mock%20Pages/Badge%20Criteria.png)


# Database 
[Database](https://github.com/wesleykarle/4ALL/blob/master/Project%20Code/Database)


# Sprint
[Sprint](https://github.com/wesleykarle/4ALL/projects/2)

:arrow_up: [Table of Contents](#contents)
<a name="contents"/>
