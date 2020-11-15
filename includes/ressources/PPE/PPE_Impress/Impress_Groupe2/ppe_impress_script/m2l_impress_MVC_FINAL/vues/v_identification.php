<?php
echo '
  <div id="content">
    <div id="left">
      <div>
        <h1>se connecter</h1>
        <form method="post" action="index.php?uc=identification&action=verifier">
          <fieldset>
          Identifiant :<input type="text" value="" name="login" class="input_login"/>
          <br /><br />Mot de Passe :<input type="password" value="" name="mdp" maxsize=100 class="input_login"/>
          <br /><br /><input type="button" value="OK" name="button" class="button" onclick="submit()"/>
          </fieldset>
        </form>
      </div>
    </div>
    <div class="clear"></div>
 ' ;
?>