<?php
echo '
  <div id="content">
    <div id="left">
      <div>
        <h1>Choisir PERIPHERIQUE</h1>
        <form method="post" action="index.php?uc=trace_periph&action=afficher">
          <fieldset>
          Peripherique :
		  <select name="prp_id">
		  <option value="0">' ;
		  foreach($execLesPeripherique as $unperif) {
			  echo '<option value="'.$unperif['PRP_ID'].'">'.$unperif['PRP_MODELE']." (salle ".$unperif['PRP_SALLE'].")" ;

		  }
		  
		  echo '</select>
		  		<input type="button" value="OK" name="button" class="button" onclick="submit()"/>
		  		</form>

      </div>
    </div>
    <div class="clear"></div>
 ' ;
?>