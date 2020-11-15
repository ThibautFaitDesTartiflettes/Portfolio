
<?php
echo '<br /><h2>'.$_POST["DATE"].'</h2><br />' ;


if ($execLesTraces->rowCount()==0)
{ 	echo "<center> Aucune impression pour cette date.</center>";


}
else{
	echo '<center style ="margin-bottom: 50px;">
 			<table>
 			<tr>
 			<th>Heure</th><th>Demandeur</th><th>Nombre de Pages</th><th>Couleur ?</th>
            </tr>';

    foreach ($execLesTraces as $uneTrace)
 	{
 		echo '<tr>' ; 
 		echo '<td>'.substr($uneTrace['TRC_QUAND'], 11).'</td>';
 			  if($uneTrace['TRC_TLS_ID'] != NULL){
 			  	 echo '<td>'.$uneTrace['TLS_NOM'].' '.$uneTrace['TLS_PRENOM'].'</td>';
 			  	
 			  }
 			  else{
 			  		echo '<td> INCONNUE</td>';
 			  }
 			  echo '<td>'.$uneTrace['TRC_NBPAGES'].'</td>' ;
 			  if ($uneTrace['TRC_COULEUR'])
 			  echo '<td>OUI</td>' ; else echo '<td>NON</td>' ;
 		echo '</tr>' ;		
 	}
 	echo '</table>
 		  </center>
	' ;

}


?>