<?php 
echo "<br><br><h1> $model (salle $salle)</h1>  ";
?>

<FORM method="POST" action="index.php?uc=gerer_periph">

  <INPUT type=hidden name="tOldID" size="22" maxlength="22" value = "<?php echo $prp_id ?>">
  <INPUT type=text name="tID" size="22" maxlength="22" value = "<?php echo $prp_id ?>"> Identifiant <br> <br>
  <INPUT type=text name="tmarque" size="22" maxlength="22" value = "<?php echo $marque ?>">  Marque <br> <br>
  <INPUT type=text name="tmodele" size="22" maxlength="22" value = "<?php echo $model ?>"> Modele <br> <br>
  <INPUT type=text name="tsalle" size="22" maxlength="22" value = "<?php echo $salle ?>"> Salle<br> <br>
  <INPUT type=text name="tprix" size="22" maxlength="22" value = "<?php echo $prix ?>"> Prix de la location <br> <br>


  <INPUT type="submit" value="Modifier le péripherique" name="submit" class = button2> 

</FORM>

<br>
