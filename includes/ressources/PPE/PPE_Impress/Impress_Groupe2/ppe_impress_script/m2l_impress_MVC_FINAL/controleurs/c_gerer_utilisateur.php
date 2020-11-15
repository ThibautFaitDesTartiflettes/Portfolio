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
		if(isset($_POST['TLSID'])) {
			$tls_id = $_POST['TLSID'];
			$login2  = $_POST['TLSLOGIN'];
			$nom2= $_POST['NOM'];
			$prenom2= $_POST['PRENOM'];
			$codecopieur2 = $_POST['CCOPIEUR'];
			$autorisation2  = $_POST['AUTORISATION'];
			$ligue2  = $_POST['LIGUE'];
			
			modifUtilisateur($tls_id,$login2,$nom2,$prenom2,$codecopieur2,$autorisation2,$ligue2);
			$execLesUtilisateur=selectUtilisateur() ;
			include("vues/v_gerer_utilisateur_critere.php");
			echo "<b>la modification a été effectuée</b>";

		}
		else{$execLesUtilisateur=selectUtilisateur();include("vues/v_gerer_utilisateur_critere.php");}
		break;

	}
	
	case 'afficher':
	{

		$tls_id=$_REQUEST['TLS_ID'] ;
		$ligne = selectUnUtilisateur($tls_id);

		$login = $ligne['TLS_LOGIN'];
		$nom   = $ligne['TLS_NOM'];
		$prenom= $ligne['TLS_PRENOM'];
		$codeCopieur=$ligne['TLS_CODECOPIEUR'];
		$autorisation=$ligne['TLS_DRT_ID'];
		$ligue = $ligne['TLS_LGU_ID'];
		include("vues/v_gerer_utilisateur_update.php");
		break;
	}
}


?>


