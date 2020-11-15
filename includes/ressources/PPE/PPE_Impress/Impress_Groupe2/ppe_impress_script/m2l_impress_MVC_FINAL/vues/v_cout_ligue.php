<h1>Consultation des coûts par ligues</h1>

<?php

	echo '	<center>
				<table>
				<tr>
				<th>Ligues</th><th>Coût total</th>
            	</tr>
	' ;
	
	foreach ($lesligues as $uneTrace)
	{
		echo '<tr>' ; 
		echo '<td>'.$uneTrace['LGU_LIBELLE'].'</td>
			  <td>'.$uneTrace['TOTPRIX'].' '.'€'.'</td>';
		echo '</tr>' ;		
	}
	echo '</table>
		  </center>
	' ;


  ?>