function getAllEmployees(){
    const allEmployeesApiUrl = "https://localhost:5001/API/empolyees";

    fetch(allEmployeesApiUrl).then(function(response){
        console.log(response);
        return response.json();
    }).then(function(json){
        let html = "<table class= \"table-bordered table-hover\" style= \"background-color: white;\">";
        html += "<tr><th>ID</th><th>FirstName</th><th>LastName</th><th>Status</th><th>OverallScore</th><th>PerformanceScore</th><th>LeadershipScore</th></tr>";
        json.forEach((empolyees)=>{
            html += "<tr><td>" + empolyees.id + "</td><td>" + empolyees.empFName +
            "</td><td>" + empolyees.empLName + "</td><td>" + empolyees.empStatus + "</td><td>" + empolyees.overallScore + "</td><td>" + 
            empolyees.performanceScore + "</td><td>" + empolyees.leadershipScore + "</td><td>"
        });
        html += "</table>";
        document.getElementById("empolyees").innerHTML = html;
    }).catch(function(error){
        console.log(error);
    });
}

function addEmployee(){
    const addEmployeeApiUrl = "https://localhost:5001/API/empolyees";
    const empFName = document.getElementById("empFName").value;
    const empLName = document.getElementById("empLName").value;
    const empStatus = document.getElementById("empStatus").value;
    const overallScore = document.getElementById("overallScore").value;
    const performanceScore = document.getElementById("performanceScore").value;
    const leadershipScore = document.getElementById("leadershipScore").value;

    fetch(addEmployeeApiUrl, {
        method: "POST",
        headers: {
            "Accept": 'application/json',
            "Content-Type": 'application/json'
        },
        body: JSON.stringify({
            empFName: empFName,
            empLName: empLName,
            empStatus: empStatus,
            overallScore: overallScore,
            performanceScore: performanceScore,
            leadershipScore: leadershipScore
        })
    })
    .then((response)=>{
        console.log(response);
        getAllEmployees();
    })
}