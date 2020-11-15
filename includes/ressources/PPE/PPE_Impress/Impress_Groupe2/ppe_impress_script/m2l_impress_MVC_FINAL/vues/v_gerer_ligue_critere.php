<?php
echo '
  <div id="content">
    <div id="left">
      <div>
        <h1>Choisir LIGUE</h1>
        <form method="post" action="index.php?uc=gerer_ligue&action=afficher">
          <fieldset>
          Ligue :
		  <select name="lgu_id">
		  <option value="0">' ;
		  foreach($execLesLigues as $uneLigue) {
			  echo '<option value="'.$uneLigue['LGU_ID'].'">'.$uneLigue['LGU_LIBELLE'] ;
		  }
		  
		  echo '</select>
		  		<input type="button" value="OK" name="button" class="button" onclick="submit()"/>
		  		</form>

      </div>
    </div>
    <div class="clear"></div>
 ' ;
?>