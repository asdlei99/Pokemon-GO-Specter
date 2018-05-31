<?php
$servername = "";
$username = "";
$password = "";
$dbname = "";

// Create connection
$conn = new mysqli($servername, $username, $password, $dbname);
// Check connection
if ($conn->connect_error) {
    die("Falha na conexao: " . $conn->connect_error);
} 

$value = $_GET["chaveLivre"];

$sql = "SELECT id FROM chavePokedex WHERE usersUsing = '0' LIMIT 0,1";
$result = $conn->query($sql);

if ($result->num_rows > 0) {
    // output data of each row
    while($row = $result->fetch_assoc()) {
        echo "" . $row["id"]. "";
    }
} else {
    echo "none";
}
$conn->close();
?>