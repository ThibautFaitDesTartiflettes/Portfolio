<?php
function verifierIdentification($loginSaisi,$mdpSaisi ) {
	require "connect_bdd.php" ;
	$sql="SELECT * 
		  FROM tb_utilisateur 
		  WHERE TLS_LOGIN='$loginSaisi'  
		  AND TLS_MDP=md5('$mdpSaisi') 
		  AND TLS_DRT_ID is not NULL" ;
		//exécution de la requete
		$exec=$bdd->query($sql) ;
		//lecture du résultat
		//si aucune ligne --> on retourne l'ID 0
		if ($exec->rowCount()==0) {	
			return 0 ;
		}
		else {
			$ligne = $exec->fetch() ;
			return $ligne['TLS_ID'] ;
		}
}

function getDroit($tls_id) {
	require "connect_bdd.php" ;
	$sql="SELECT * 
		  FROM tb_utilisateur 
		  WHERE TLS_ID=$tls_id  
		  AND TLS_DRT_ID is not NULL" ;
		//exécution de la requete
		$exec=$bdd->query($sql) ;
		//lecture du résultat
		//si aucune ligne --> on retourne l'ID 0
		if ($exec->rowCount()==0) {	
			return 0 ;
		}
		else {
			$ligne = $exec->fetch() ;
			return $ligne['TLS_DRT_ID'] ;
		}
}

function selectLigues() {
	require "connect_bdd.php" ;
	$sql="SELECT * 
		  FROM tb_ligue 
		  ORDER BY LGU_ID" ;
	//exécution de la requete
	$exec=$bdd->prepare($sql) ;
	$exec->execute() ;
	//on retourne un curseur contenant l'ensemble des lignes de la table tb_ligue
	$curseur=$exec->fetchAll();
	return $curseur;
}

function selectUneLigue($lgu_id) {
	require "connect_bdd.php" ;
	$sql="SELECT LGU_LIBELLE
		  FROM tb_ligue 
		  WHERE LGU_ID = $lgu_id" ;
	//exécution de la requete
	$exec=$bdd->prepare($sql) ;
	$exec->execute() ;
	//on retourne la ligne de la table tb_ligue associée aa l'ID de la ligue $lgu_id
	$uneLigne=$exec->fetch();
	return $uneLigne;
}

function selectLigueTrace($lgu_id) {
	require "connect_bdd.php" ;
	$sql="SELECT * 
		  FROM tb_trace
		  INNER JOIN tb_utilisateur ON TRC_TLS_ID = TLS_ID
		  WHERE TLS_LGU_ID = $lgu_id
		  ORDER BY TRC_QUAND DESC" ;
	//exécution de la requete
	$exec=$bdd->prepare($sql) ;
	$exec->execute() ;
	//on retourne le résultat de l'exécution de la requete
	return $exec;
}

function selectUtilisateur() {
	require "connect_bdd.php" ;
	$sql="SELECT * 
		  FROM tb_utilisateur
		  ORDER BY TLS_NOM" ;
	//ex�cution de la requete
	$exec=$bdd->prepare($sql) ;
	$exec->execute() ;
	//on retourne un curseur contenant l'ensemble des lignes de la table tb_utilisateur
	$curseur=$exec->fetchAll();
	return $curseur;
}

function selectUnUtilisateur($tls_id) {
	require "connect_bdd.php" ;
	$sql="SELECT *
		  FROM tb_utilisateur 
		  WHERE TLS_ID = $tls_id" ;
	//ex�cution de la requete
	$exec=$bdd->prepare($sql) ;
	$exec->execute() ;
	//on retourne la ligne de la table tb_ligue associ�e aa l'ID de l'utilistaeur
	$uneLigne=$exec->fetch();
	return $uneLigne;
}

function selectUtilisateurTrace($tls_id) {
	require "connect_bdd.php" ;
	$sql="SELECT * 
		  FROM tb_trace
		  INNER JOIN tb_utilisateur ON TRC_TLS_ID = TLS_ID
		  WHERE TLS_ID = $tls_id
		  ORDER BY TRC_QUAND DESC" ;
	//ex�cution de la requete
	$exec=$bdd->prepare($sql) ;
	$exec->execute() ;
	//on retourne le r�sultat de l'ex�cution de la requete
	return $exec;
}





// Gestion des peripheriques ----------------------------

function selectPeripheriques() {
	require "connect_bdd.php" ;
	$sql="SELECT * 
		  FROM tb_peripherique 
		  ORDER BY PRP_MODELE" ;
	$exec=$bdd->prepare($sql) ;
	$exec->execute() ;
	$curseur=$exec->fetchAll();
	return $curseur;
}

function selectPeripheriquesETPRIX() {
	require "connect_bdd.php" ;
	$sql="SELECT PRP_MODELE,PRP_SALLE,PRP_PRIXLOCATION,sum(PRIX) as PRIXTOT FROM tb_peripherique
		INNER JOIN tb_prix ON PRP_ID = PRIX_PRP_ID
		GROUP BY PRP_MODELE,PRP_SALLE
		ORDER BY PRP_MODELE";
	$exec=$bdd->prepare($sql) ;
	$exec->execute() ;
	$curseur=$exec->fetchAll();
	return $curseur;
}


function selectUnPeripherique($prp_id) {
	require "connect_bdd.php" ;
	$sql="SELECT *
		  FROM tb_peripherique
		  WHERE PRP_ID = $prp_id" ;
	$exec=$bdd->prepare($sql) ;
	$exec->execute() ;
	$unPeripherique=$exec->fetch();
	return $unPeripherique;
}



function selectPeripheriqueTrace($prp_id) {
	require "connect_bdd.php" ;
	$sql="SELECT * 
		  FROM tb_trace
		  INNER JOIN tb_utilisateur ON TRC_TLS_ID = TLS_ID
		  INNER JOIN tb_peripherique ON TRC_PRP_ID = PRP_ID
		  WHERE PRP_ID = $prp_id 
		  ORDER BY TRC_QUAND DESC" ;
	$exec=$bdd->prepare($sql) ;
	$exec->execute() ;
	return $exec;
}


function modifPeripherique($oldPrp_id,$prp_id,$marque,$modele,$salle,$prix){
	require "connect_bdd.php" ;
	$sql="UPDATE tb_peripherique SET PRP_ID = '$prp_id',
	PRP_MARQUE = '$marque',
	PRP_MODELE = '$modele',
	PRP_SALLE = '$salle',
	PRP_PRIXLOCATION = '$prix'
	WHERE PRP_ID = '$oldPrp_id'";
	$exec=$bdd->prepare($sql) ;
	$exec->execute() ;
}


function modifligue($oldlgu_id, $lgu_id, $lgu_libelle)
{
	require "connect_bdd.php";
	$sql = "UPDATE tb_ligue SET LGU_ID ='$lgu_id', LGU_LIBELLE = '$lgu_libelle' where LGU_ID = '$oldlgu_id'";
	$exec=$bdd->prepare($sql) ;
	$exec->execute() ;
}

function selectLiguesETPRIX()
{
	require "connect_bdd.php";
	$sql = "SELECT LGU_LIBELLE,sum(PRIX) as TOTPRIX  FROM tb_prix 
	INNER JOIN tb_trace ON PRIX_TRC_NUM = TRC_NUM
    INNER JOIN tb_utilisateur ON TRC_TLS_ID = TLS_ID
    INNER JOIN tb_ligue ON TLS_LGU_ID = LGU_ID
    GROUP BY LGU_LIBELLE
    order by TOTPRIX DESC";
	$exec=$bdd->prepare($sql) ;
	$exec->execute() ;
  	$curseur=$exec->fetchAll();
    return $curseur;

}

function modifUtilisateur($id,$login,$nom,$prenom,$ccopieur,$autorisation,$ligue){
	require "connect_bdd.php";
	$sql = "UPDATE tb_utilisateur SET
	TLS_LOGIN='$login',
	TLS_NOM ='$nom',
	TLS_PRENOM = '$prenom',
	TLS_CODECOPIEUR ='$ccopieur',
	TLS_DRT_ID = '$autorisation',
	TLS_LGU_ID = '$ligue'
	WHERE TLS_ID='$id'";
    $exec=$bdd->prepare($sql) ;
    $exec->execute() ;
}

function periodeETprix($hdebut,$hdfin){
	require "connect_bdd.php";
	$sql = "SELECT sum(PRIX) as TOTPRIX 
	FROM tb_prix
	INNER JOIN tb_trace ON TRC_NUM = PRIX_TRC_NUM
	WHERE TRC_QUAND BETWEEN '$hdebut' and '$hdfin'";
    $exec=$bdd->prepare($sql) ;
    $exec->execute() ;
    $curseur=$exec->fetchAll();
    return $curseur; }




?>