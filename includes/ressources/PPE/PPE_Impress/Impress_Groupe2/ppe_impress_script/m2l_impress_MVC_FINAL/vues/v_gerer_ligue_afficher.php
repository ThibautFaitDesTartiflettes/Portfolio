<?php 
echo "<br><br><h1> $lgu_libelle</h1>  ";
?>

<FORM method="POST" action="index.php?uc=gerer_ligue">

  <INPUT type=hidden name="tOldid" size="22" maxlength="22" value = "<?php echo $lgu_id ?>">
  <INPUT type=text name="tiD" size="22" maxlength="22" value = "<?php echo $lgu_id ?>"> Identifiant <br> <br>
  <INPUT type=text name="tlibelle" size="22" maxlength="22" value = "<?php echo $lgu_libelle ?>"> Libelle <br> <br>


  <INPUT type="submit" value="Modifier le péripherique" name="submit" class = button2> 

</FORM>

<br>