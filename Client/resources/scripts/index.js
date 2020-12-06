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
            empolyees.performanceScore + "</td><td>" + empolyees.leadershipScore + "</td><td>" + "<button id=\"edit\" class= \"btn-danger btn-sm clickbutton\" onclick=\"editEmployee("+empolyees.id+")\">Edit</button></td></tr>"
        });
        html += "</table>";
        document.getElementById("empolyees").innerHTML = html;
    }).catch(function(error){
        console.log(error);
    });
}