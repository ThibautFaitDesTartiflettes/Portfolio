<?php
function verifierIdentification($loginSaisi,$mdpSaisi) {
    require "connexion.php" ;
    $sql="select * from utilisateur";
    $exec=$bdd->query($sql);
    $trouve = false ;
    $fin=false ;
    while (!$trouve && !$fin)
    {
        if ($ligne = $exec->fetch())
        {

            if ($ligne['loginUtilisateur']==$loginSaisi && $ligne['mdpUtilisateur']==$mdpSaisi)
            {
                $trouve = true ;
                $_SESSION['id']=$ligne['idUtilisateur'] ;
                $_SESSION['type']=$ligne['typeUtilisateur'] ;
            }
        }
        else
        {
            $fin = true ;
        }
    }
    return $trouve ;
}

?>