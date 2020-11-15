<?php 

function selecteDateTrace($date){
	require "connect_bdd.php" ;
	$sql="SELECT *
		  FROM tb_trace
		  INNER JOIN tb_utilisateur ON TRC_TLS_ID = TLS_ID 
		  WHERE  SUBSTR(TRC_QUAND,1,10) = '$date'
		  ORDER BY SUBSTR(TRC_QUAND,1,10) DESC" ;
	
	//exécution de la requete
	$exec=$bdd->prepare($sql) ;
	$exec->execute() ;
	//on retourne le résultat de l'exécution de la requete
	return $exec;
}


 ?>