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
		if(isset($_POST['tiD'])) 
		{
			$lgu_id = $_POST['tOldid'];
			$newiD  = $_POST['tiD'];
			$lgu_libelle2= $_POST['tlibelle'];

			modifligue($lgu_id,$newiD,"$lgu_libelle2");
			$execLesLigues=selectLigues();
			include("vues/v_gerer_ligue_critere.php");
			echo "<b>la modification a été effectuée</b>";
			break;
		}
		else{
			$execLesLigues=selectLigues() ;
			include("vues/v_gerer_ligue_critere.php");
			break;
		}
		
	}
	
	case 'afficher':
	{
		$lgu_id=$_REQUEST['lgu_id'] ;
		$ligne = selectUneLigue($lgu_id);
		$lgu_libelle = $ligne['LGU_LIBELLE'];
		include("vues/v_gerer_ligue_afficher.php");
		break;

	}
}


?>