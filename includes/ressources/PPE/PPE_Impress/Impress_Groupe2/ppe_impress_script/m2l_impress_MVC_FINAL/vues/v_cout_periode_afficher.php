<h1>Consultation des coûts par periode</h1>

<?php

	echo '	<center>
			<table>
			<tr>
			<th>Heure debut</th><th>Heure fin</th><th>Coût tôtal</th>
            </tr>
	' ;
	if(!isset($laLigne[0][0])){
		$laLigne[0][0]=0;
	}

		echo '<tr>' ; 
		echo '<td>'.$heuremin.'</td>
			  <td>'.$heuremax.'</td>
			  <td>'.$laLigne[0][0].'€'.'</td>' ;
		echo '</tr>' ;		

	echo '</table>
		  </center>
	' ;


  ?>