<?php
echo '<br /><h2>'.$lePeripherique['PRP_MODELE'].'</h2><br />' ;

if ($execLesTraces->rowCount()==0)
{ 
	echo 'Aucune impression' ;
}
else
{
	echo '	<center>
			<table>
			<tr>
			<th>Date et heure</th><th>Demandeur</th><th>Nombre de Pages</th><th>Couleur ?</th>
            </tr>
	' ;
	
	foreach ($execLesTraces as $uneTrace)
	{
		echo '<tr>' ; 
		echo '<td>'.$uneTrace['TRC_QUAND'].'</td>
			  <td>'.$uneTrace['TLS_NOM'].' '.$uneTrace['TLS_PRENOM'].'</td>
			  <td>'.$uneTrace['TRC_NBPAGES'].'</td>' ;
			  if ($uneTrace['TRC_COULEUR'])
			  echo '<td>OUI</td>' ; else echo '<td>NON</td>' ;
		echo '</tr>' ;		
	}
	echo '</table>
		  </center>
	' ;
}
?>