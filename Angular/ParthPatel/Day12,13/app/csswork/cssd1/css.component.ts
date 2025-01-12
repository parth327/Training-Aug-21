import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-css',
  template: `
  <p><p>
    <div class="container">
    <div id="main">
    <div id="header">
    <p id="name">Parth D Patel</p>
    </div>
<div class="right">
    <h3>CV Highlights</h3>
    <p>
        <ul>
            <li>Currently going through Dot Net Training</li>
            <li>Learnt Basic DotNet Technology using HTML,CSS,Javascript,C# </li>
            <li>An independent, dedicated, efficient person.</li>
            <li>Good Communication Skills, Presentation Skills, attitude towards leadership, authorisation and delegation, conflict resolution and negotiation and a very good team worker.</li>
        </ul>
    <h3>Professional Experience</h3>
    <h4 id="company-name">Patel Web Solution</h4>
    <p></p><p id="job-title"><strong>Job Trainee</strong></p>
    <p id="job-responsibilities">Training Tasks</p>
    <p>
        <ul>
            <li>Learning about Windows Forms</li>
            <li>Learn Front End Technologies Like HTML,CSS,JS etc..</li>
            <li>Learn Database Basic Concepts </li>
            <li>Learn How to make a Website</li>
        </ul>
    <h3>Educational Qualifications</h3>
    <table>
        <tr id="heading">
            <td>Qualification</td>
            <td>Board</td>
            <td>Percentage / Grades</td>
            <td>Year</td>
        </tr>
        <tr>
            <td>S.S.C</td>
            <td>G.S.H.S.E.B</td>
            <td>86.66%</td>
            <td>2015</td>
        </tr>
        <tr>
            <td>H.S.C (Science Stream)</td>
            <td>G.S.H.S.E.B </td>
            <td>78.17%</td>
            <td>2017</td>
        </tr>
        <tr>
            <td> B.E(Computer) </td>
            <td> G.T.U </td>
            <td> 7.68 C.G.P.A   </td>
            <td>2021</td>
        </tr>
    </table>
    <h3>Technical Skills</h3>
    <p>
        <ul>
            <li>
                <span id="course-name">Operating Systems:</span> Microsoft Windows 7,Microsoft Windows 10 Pro
            </li>
            <li>
                <span id="course-name">Application Software:</span> Visual Studio Code , Visual Studio 2019 , SSMS
            </li>
            <li>
                <span id="course-name">Programming Skills:</span>HTML, CSS,JavaScript,Asp.Net C#
            </li>
        </ul>
    <h3>Certifications / Awards:</h3>
    <p>
        <ul>
            <li>Certificate of Completed Training Of ASP.Net C# at Patel Web Solution,Krishnanagar</li>
        </ul>
    <h3>Personal Information:</h3>
    <p>
        <ul>
            <li>
                A young, determined hard and smart working person. I believe in task based roles and complete ownership of work.
            <li>
                <span id="course-name">Languages Known:</span>English, Hindi, Gujarati
            </li>
            <li>
                <span id="course-name">Hobbies:</span>I love IT related books, playing Chess, listening music, surfing Internet, self-learning through e-courses.
            </li>
        </ul>
    <h3>Other Information</h3>
    <p>
        <ul>
            <li>
                <span id="course-name">Expected Salary:</span>As per company standards
            </li>
            <li>
                <span id="course-name">Area of Interest:</span>Software Development, Programming, Start-ups, Coding, App Development
            </li>
            <li>
                <span id="course-name">Joining Date:</span>Immediate
            </li>
        </ul>
    <h3>Declaration</h3>
    <p>
        I hereby declare that the details furnished above are true and correct to the best of my knowledge and belief.
    </p>
    <h3>Projects :</h3>
    <video width="320" height="240" controls>
        <source src="../../assets/project.mp4" type="video/mp4">
    </video>
</div>
<div id="footer"></div>
</div>
</div>
  `,
  styles: [`
  body{
    text-align:left;
}
#main{
  width:1050px;
}
div {
border-radius: 5px;
}
#name {
    float: left;
    margin-left: 20px;
    font-size: 26px;
    font-family: Verdana, sans-serif;
    color: blue;
    background-color: gainsboro;
    border: 1px solid black;
    padding: 8px;
    border-radius: 5px;
}
#email {
    float: right;
    margin-right: 65px;
    font-size: 26px;
    font-family: Verdana, sans-serif;
    color: blue;
    background-color: gainsboro;
    border: 1px solid black;
    padding: 8px;
    border-radius: 5px;
    width:300px;
}
#contact {
margin-left: 45%;
padding-bottom: 10px;
font-size: 16px;
font-family: Verdana, sans-serif;
color: #ffffff;
}

.right {
float: left;
padding-left: 5px;
height: auto;
width: 85%
}
#footer {
height: 40px;
clear: both;
}
h3 {
    border: 1px solid black;
    margin: 10px;
    padding: 10px;
    width: 96%;
    border-radius: 5px;
    color: blue;
    text-decoration: none;
    background-color: gainsboro;
    text-align: center;
}
#job-responsibilities {
padding: 1px;
}
.job-title {
font-weight: bold;
}
table {
border: 1px black;
}
td {
padding: 2px;
border: 1px solid black;
}
#course-name {
font-weight: bold;
}
#company-name {
height: 2px;
text-decoration: none;
}
#job-title {
height: 5px;
}
.job-duration {
float: right;
}
#heading {
font-weight: bold;
}


  `
  ]
})
export class CssComponent implements OnInit {

  constructor() { }

  ngOnInit(): void {
  }

}
