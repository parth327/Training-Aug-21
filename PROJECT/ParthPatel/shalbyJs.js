// Appointment Form
  // function appointment (e) {
    if(!localStorage.getItem("data")){
      localStorage.setItem("data","[]");
    }

  let appointments = JSON.parse(localStorage.getItem("data"));
  updateHistory(appointments);
  // }

  $("#appointment-btn").on("click",function(event){
    let fName = document.getElementById('fName').value;
    let lName = document.getElementById('lName').value;
    let hospital = document.getElementById('hospital').value;
    let date = document.getElementById('date').value;
    let time = document.getElementById('time').value;
    let email = document.getElementById('email').value;
    let tel = document.getElementById('tel').value;
    
    // console.log(fName,lName);


    let data ={
      fName:fName,
      lName:lName,
      hospital:hospital,
      date:date,
      time:time,
      email:email,
      tel:tel
    }

    appointments.push(data);

    updateHistory(appointments);
    
    localStorage.setItem('data',JSON.stringify(appointments));
    // console.log(localStorage.getItem('data'));

    location.reload();
  })

  function updateHistory(appointments) {
    $("#history-tbody").empty();

    $.each(appointments,function(index,data) {
      $("#history-tbody").append(
        `
        <tr id="${index}">
          <td>${data.fName}</td>
          <td>${data.lName}</td>
          <td>${data.hospital}</td>
          <td>${data.date}</td>
          <td>${data.time}</td>
          <td>${data.email}</td>
          <td>${data.tel}</td>
        </tr>
        `
      )
    })
  }


///////////////////////////////////////////////////////// slider ///////////////////////////////////////////////////
function bigSlider(x) {
    x.style.width = "30%";
  }
  
function normalSlider(x) {
    x.style.width = "16%";
  }

  //////////////////////////////////////////////chat circle////////////////////////////////////////////////////////

  function openForm() {
    document.getElementById("myForm").style.display = "block";
  }
  
  function closeForm() {
    document.getElementById("myForm").style.display = "none";
  }
 
  function openSubmit(){
    document.getElementById("myForm").style.backgroundColor="#1e5eac"; 
    document.getElementById("myForm").style.color="white";
    document.getElementById("myForm").style.padding= "10px"; 
    document.getElementById("myForm").innerHTML = "Thank You , We'll answer you shortly !";
    document.getElementById("myForm").style.display = "block";
  }

//Subscribe

  function Newsletter(){
    myWindow = window.open("formMail.html", "width=700", "height=500");
  }

  // click To Chat

  function subclickToChat(){
    document.getElementById("successMsg").innerHTML="Your Message was sent successfully !";  
  }

  function clickToChat(){
    myWindow = window.open("ClickToChat.html", "width=700", "height=500");
  }
    
    