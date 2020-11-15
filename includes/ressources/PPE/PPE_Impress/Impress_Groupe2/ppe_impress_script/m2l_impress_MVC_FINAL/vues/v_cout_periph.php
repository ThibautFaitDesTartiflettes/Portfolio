<h1>Consultation des coûts par periphérique</h1>

<?php

	echo '	<center>
			<table>
			<tr>
			<th>Periphérique</th><th>Coût  total des impressions</th><th>Coût location</th>
            </tr>
	' ;
	
	foreach ($lesperif as $uneTrace)
	{
		echo '<tr>' ; 
		echo '<td>'.$uneTrace['PRP_MODELE'].' (salle '.$uneTrace['PRP_SALLE'].')'.'</td>
			  <td>'.$uneTrace['PRIXTOT'].' '.'€'.'</td>
			  <td>'.$uneTrace['PRP_PRIXLOCATION'].'€ / mois'.'</td>' ;
		echo '</tr>' ;		
	}
	echo '</table>
		  </center>
	' ;


  ?>