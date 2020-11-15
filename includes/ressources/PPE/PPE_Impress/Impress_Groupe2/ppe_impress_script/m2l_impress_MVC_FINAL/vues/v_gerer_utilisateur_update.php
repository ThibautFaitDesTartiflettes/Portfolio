<?php 
echo "<br><br><h1> $nom $prenom</h1>  ";
?>

<FORM method="POST" action="index.php?uc=gerer_util">

  <INPUT type=hidden name="TLSID" size="22" maxlength="22" value = "<?php echo $tls_id ?>">
  <INPUT type=text name="TLSLOGIN" size="22" maxlength="22" value = "<?php echo $login ?>"> LOGIN <br> <br>
  <INPUT type=text name="NOM" size="22" maxlength="22" value = "<?php echo $nom ?>">  NOM <br> <br>
  <INPUT type=text name="PRENOM" size="22" maxlength="22" value = "<?php echo $prenom ?>"> PRENOM <br> <br>
  <INPUT type=text name="CCOPIEUR" size="22" maxlength="22" value = "<?php echo $codeCopieur ?>"> CODECOPIER <br> <br>
  <INPUT type=text name="AUTORISATION" size="22" maxlength="22" value = "<?php echo $autorisation ?>"> AUTORISATION <br> <br>
  <INPUT type=text name="LIGUE" size="22" maxlength="22" value = "<?php echo $ligue ?>"> LIGUE <br> <br>



  <INPUT type="submit" value="Modifier l'utilisateur " name="submit" class = button2> 

</FORM>

<br>
