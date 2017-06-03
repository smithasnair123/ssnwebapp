<html>
		<head>
	<title>Find a Contact</title>
	<meta name="viewport" content="width=device-width, initial-scale=1">
<link rel="stylesheet" href="styles/custom.css" />
<link rel="stylesheet" href="themes/rasmussenthemeroller.min.css" />
<link rel="stylesheet" href="themes/jquery.mobile.icons.min.css" />
<link rel="stylesheet" href="http://code.jquery.com/mobile/1.4.5/jquery.mobile.structure-1.4.5.min.css" />
<script src="http://code.jquery.com/jquery-1.11.1.min.js"></script>
<script src="http://code.jquery.com/mobile/1.4.5/jquery.mobile-1.4.5.min.js"></script>
<script src="javascript/storage.js"></script>
</head>
	<body>
		<div id="page" data-role="page" data-theme="b" >
	<div data-role="header" data-theme="b">
<h1>
	Find your contact
		</h1>	</div>
				<div data-role="content">


					<?php
					include 'config.php';
					include 'opendb.php';

					$name = (isset($_POST['name'])    ? $_POST['name']   : '');

					$sql= "SELECT EmployeeId, EmployeeName, Address, DepartmentName, HeadOftheDepartment  from employee
JOIN department on employee.DepartmentId = department.id
WHERE employee.EmployeeName LIKE '$name'
ORDER BY employee.EmployeeName ASC LIMIT 1";
					$result = mysqli_query($conn, $sql);

					if (mysqli_num_rows($result) > 0) {
					    // output data of each row
					    while($row = mysqli_fetch_assoc($result)) {
									echo "ID: " . $row["EmployeeId"]. "<br>";
					        echo "Employee Name: " . $row["EmployeeName"]. "<br>";
					        echo "Address: " . $row["Address"]. "<br>";
							echo "Department Name: " . $row["DepartmentName"]. "<br>";
							echo "Head Of Department: " . $row["HeadOftheDepartment"]. "<br>";
					    }
					} else {
					    echo "0 results";
					}

					mysqli_close($conn);

					?>

				<div data-role="footer" data-theme="b">
	  <h4>Darice Corey-Gilbert &copy; 2017</h4>
	</div>
	</body>
</html>
