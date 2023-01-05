function checkValue() {
	var x = document.getElementById("userName").value;
	if (x === null) {
		document.getElementById("demo").innerHTML = "Vänligen fyll i ett användarnamn!";
	}
}
