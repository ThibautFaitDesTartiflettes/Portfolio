<?php
echo '
  <div id="content">
    <div id="left">
      <div>
        <h1>Choisir UTILISATEUR</h1>
        <form method="post" action="index.php?uc=gerer_util&action=afficher">
          <fieldset>
          Utilisateur :
		  <select name="TLS_ID">
		  <option value="0">' ;
		  foreach($execLesUtilisateur as $unTls) {
			  echo '<option value="'.$unTls['TLS_ID'].'">'.$unTls['TLS_LOGIN']." (Nom : ".$unTls['TLS_NOM'].")" ;

		  }
		  
		  echo '</select>
		  		<input type="button" value="OK" name="button" class="button" onclick="submit()"/>
		  		</form>

      </div>
    </div>
    <div class="clear"></div>
 ' ;
?>