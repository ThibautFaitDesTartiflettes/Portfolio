<?php
include("vues/v_menu.php") ;
		
if(!isset($_REQUEST['action']))
     $action = 'saisir';
else
	$action = $_REQUEST['action'];


	
switch($action)
{
	case 'saisir':
	{	
		if(isset($_POST['tID'])) {
			$prp_id = $_POST['tOldID'];
			$newID  = $_POST['tID'];
			$marque2= $_POST['tmarque'];
			$modele2= $_POST['tmodele'];
			$salle2 = $_POST['tsalle'];
			$prix2  = $_POST['tprix'];
			
			modifPeripherique($prp_id,$newID,"$marque2","$modele2","$salle2",$prix2);
			$execLesPeripherique=selectPeripheriques() ;
			include("vues/v_gerer_peripherique_critere.php");
			echo "<b>la modification a été effectuée</b>";

		}
		else{$execLesPeripherique=selectPeripheriques();include("vues/v_gerer_peripherique_critere.php");}
		break;

	}
	
	case 'afficher':
	{
		$prp_id=$_REQUEST['prp_id'] ;
		$ligne = selectUnPeripherique($prp_id);
		$marque = $ligne['PRP_MARQUE'];
		$model = $ligne['PRP_MODELE'];
		$salle = $ligne['PRP_SALLE'];
		$prix = $ligne["PRP_PRIXLOCATION"];
		include("vues/v_gerer_peripherique_update.php");
		break;
	}
}


?>


