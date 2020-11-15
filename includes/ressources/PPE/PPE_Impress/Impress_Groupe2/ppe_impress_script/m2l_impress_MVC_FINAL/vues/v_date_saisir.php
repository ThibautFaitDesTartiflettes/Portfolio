 <br>
 <br>
 <center style ="margin-bottom: 50px;">
 	 <h1>Choisir une date : </h1>
 	<form method="post" action="index.php?uc=trace_date&action=afficher">
 	<?php 
 		$MaxDate = date("Y-m-d");
 		echo '<input type="date" id="start" name="DATE"
       value="2013-11-02"
       min="2010-01-01" max='.$MaxDate.'
       />';

 	 ?>
 	
 	<input type="button" value="OK" name="button" class="button" onclick="submit()"/>
 	</form>
 </center>
