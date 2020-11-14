<!doctype html>
<html lang="fr">
<head>
    <!-- Required meta tags -->
    <meta charset="utf-8">
    <meta name="viewport" content="width=device-width, initial-scale=1, shrink-to-fit=no">
    <!-- Bootstrap CSS -->
    <link rel="stylesheet" href="https://stackpath.bootstrapcdn.com/bootstrap/4.5.2/css/bootstrap.min.css" integrity="sha384-JcKb8q3iqJ61gNV9KGb8thSsNjpSL0n8PARn9HuZOnIxN0hoP+VmmDGMN5t9UJ0Z" crossorigin="anonymous">
    <link rel="stylesheet" href="includes/css/style.css">
    <link href="https://fonts.googleapis.com/css2?family=Poiret+One&display=swap" rel="stylesheet">
    <script src="https://kit.fontawesome.com/be8b49b8eb.js"></script>
    <title>Portfolio - Thibaut Meslin</title>
</head>
<body>
<header>
    <div class="container">
        <nav class="navbar navbar-expand-lg navbar-light">
            <a class="navbar-brand" href="#"><img src="includes/img/campfire.gif" width="60" height="60"></a>
            <button class="navbar-toggler" type="button" data-toggle="collapse" data-target="#navbarSupportedContent" aria-controls="navbarSupportedContent" aria-expanded="false" aria-label="Toggle navigation">
            <span class="navbar-toggler-icon"></span>
            </button>
        
            <div class="collapse navbar-collapse" id="navbarSupportedContent">
            <ul class="navbar-nav ml-lg-auto">
                <li class="nav-item active">
                <a class="nav-link" href="#">Accueil<span class="sr-only">(current)</span></a>
                </li>
                <li class="nav-item">
                <a class="nav-link" href="#profil">Profil</a>
                </li>
                <li class="nav-item">
                <a class="nav-link" href="#PPE">PPE</a>
                </li>
                <li class="nav-item">
                <a class="nav-link" href="#stages">Stage</a>
                </li>
                <li class="nav-item">
                <a class="nav-link" href="#dev">Développement</a>
                </li>
                <li class="nav-item">
                <a class="nav-link" href="#cyberEdu">CyberEdu</a>
                </li>
                <li class="nav-item">
                <a class="nav-link" href="#veilles">Veilles</a>
                </li>
                <li class="nav-item">
                <a class="nav-link" href="#CV">CV</a>
                </li>
                <li class="nav-item">
                <a class="nav-link" href="#contact">Contact</a>
                </li>
            </div>
        </nav>
    </div>
</header>
<section class="banner">
    <div class="container">
        <div class="row">
            <div class="col-sm-6">
                <h2 id="typed"></h2>
                <p>Une tasse de café &#9749; ? Un petit gâteau 🍰 ? Alors vous êtes prêt pour la visite, choisissez donc une option dans le menu ci-dessus, sur le bouton en dessous ou scrollez ! <br><strong>Bonne visite !</strong></p>
                <a href="#" class="btnD1">M'emmener quelque part</a>
            </div>
        </div>
    </div>
</section>
<section id="profil" data-text="Section 1">
    <div class="container-fluid d-flex h-100 background">
        <div class="row align-self-center">
            <div class="col-sm-8 pres">
                <h1 class="text-center">Qui suis-je ?</h1>
                <p class="mx-5 text-justify">Moi c'est Thibaut Meslin ! J'ai 19 ans et je suis étudiant en 2ème année du BTS SIO du lycée saint Adjutor à Vernon.</p>
                <p class="mx-5 text-justify">Je suis en option SLAM soit développement, j'étudie donc la programmation.J'ai un baccalauréat scientifique option Sciences de l'ingénieur et spécialité Informatique et Sciences du Numérique, obtenu avec mention assez bien. Je possède de solides compétences en informatique en général et surtout en développement dans divers langages couplé avec d'aussi solides compétences en langue.</p>
                <p class="mx-5 text-justify">Je connais et ai une bonne maîtrise des langages C#, Python, Php et SQL et les utilise couramment dans divers projets. J'ai déjà développé de multiples applications utilisant ces langages et quelques petits jeux. Quant aux langues, je parle couramment l'anglais et l'espagnol.</p>
                <p class="mx-5 text-justify">Je souhaiterais poursuivre mes études en école d'ingénieurs afin de devenir développeur de jeux vidéo ou bien m'orienter dans la direction du projet.</p>
                <p class="mx-5 text-justify">Je suis également entraîneur de tennis dans mon club et m'occupe d'enseigner et de gérer des groupes des 6 à 8 élèves auxquels j'apprends ce sport. Je pratique également le basket-ball et la musculation ce qui m'a permis de savoir travailler en équipe et garder son sang-froid.</p>
            </div>
            <div class="col-sm-4 align-self-center">
                <div class="img-wrap text-center">
                    <img src="includes/img/pp_profil2.jpg">
                </div>
            </div>
        </div>
    </div>
</section>
<section id="PPE" data-text="Section 2">
    <p>Si debugger, c’est supprimer des bugs, alors programmer ne peut être que les ajouter — Edsger Dijkstra</p>
</section>
<section id="stages" data-text="Section 3">
    <p>Si debugger, c’est supprimer des bugs, alors programmer ne peut être que les ajouter — Edsger Dijkstra</p>
</section>
<section id="dev" data-text="Section 4">
    <p>Si debugger, c’est supprimer des bugs, alors programmer ne peut être que les ajouter — Edsger Dijkstra</p>
</section>
<section id="cyberEdu" data-text="Section 5">
    <p>Si debugger, c’est supprimer des bugs, alors programmer ne peut être que les ajouter — Edsger Dijkstra</p>
</section>
<section id="veilles" data-text="Section 6">
    <p>Si debugger, c’est supprimer des bugs, alors programmer ne peut être que les ajouter — Edsger Dijkstra</p>
</section>
<section id="CV" data-text="Section 7">
    <p>Si debugger, c’est supprimer des bugs, alors programmer ne peut être que les ajouter — Edsger Dijkstra</p>
</section>
<section id="contact" data-text="Section 8">
    <?php
        if(isset($_POST['MailForm'])){
            if (!empty($_POST['personne']) AND !empty($_POST['mail']) AND !empty($_POST['telephone']) AND !empty($_POST['message']))
            {
                $header="MIME-Version: 1.0\r\n";
                $header.='From:"thibaut.meslin.bts@free.fr"<support@thibautmeslinbts.fr>'."\n";
                $header.='Content-Type:text/html; charset="utf-8"'."\n";
                $header.='Content-Transfer-Encoding: 8bit';
        
                $message='
                <html>
                    <body>
                        <div align="center">
                            <img src="http://thibaut.meslin.bts.free.fr/Portfolio/includes/img/banniere_mail.gif">
                            <br />
                            <u>Nom de l\'expéditeur :</u>'.$_POST['personne'].'<br />
                            Mail de l\'expéditeur :'.$_POST['mail'].'<br />
                            Société de l\'expéditeur :'.$_POST['societe'].'<br />
                            Téléphone de l\'expéditeur :'.$_POST['telephone'].'<br />
                            <br />
                            '.nl2br($_POST['message']).'
                            <br />
                        </div>
                    </body>
                </html>
                ';
        
                mail("thibaut.meslin@hotmail.com", "CONTACT - Portoflio", $message, $header);
                $ok = "Votre message a bien été envoyé";
            }
            else{
                $msg = "Les champs avec * sont obligatoires";
            }
        }
    ?>
    <div class="contactUs align-self-center">
        <h1 class="title">Contactez moi !</h1>
        <form method="POST" action="">
            <div class="container">
                <div class="contact-form row">
                    <div class="form-field col-lg-6">
                        <input type="text" id="name" class="input-text" name="personne" value="<?php if(isset($_POST['personne'])) {echo $_POST['personne'];} ?>" required>
                        <label for="name" class="label">Qui êtes-vous ? *</label>
                    </div>
                    <div class="form-field col-lg-6">
                        <input type="email" id="email" class="input-text" name="mail" value="<?php if(isset($_POST['mail'])) {echo $_POST['mail'];} ?>" required>
                        <label for="email" class="label">Adresse mail ? *</label>
                    </div>
                    <div class="form-field col-lg-6">
                        <input type="text" id="company" class="input-text" name="societe" value="<?php if(isset($_POST['societe'])) {echo $_POST['societe'];} ?>">
                        <label for="company" class="label">Société ?</label>
                    </div>
                    <div class="form-field col-lg-6">
                        <input type="tel" pattern="^((\+\d{1,3}(-| )?\(?\d\)?(-| )?\d{1,5})|(\(?\d{2,6}\)?))(-| )?(\d{3,4})(-| )?(\d{4})(( x| ext)\d{1,5}){0,1}$" id="phone" class="input-text" name="telephone" 
                        value="<?php if(isset($_POST['telephone'])) {echo $_POST['telephone'];} ?>" required>
                        <label for="phone" class="label">Téléphone ? *</label>
                    </div>
                    <div class="form-field col-lg-12">
                        <textarea id="message" class="input-text" name="message" value="<?php if(isset($_POST['message'])) {echo $_POST['message'];} ?>" required></textarea>
                        <label for="message" class="label">Que voulez-vous me dire ? *</label>
                    </div>
                    <div class="form-field col-lg-12">
                        <input type="submit" value="Envoyer" class="submit-btn" name="MailForm">
                    </div>
                    <?php
                        if(isset($erreur)){
                            echo '<label style="color: red">'.$erreur.'</label>';
                        }
                        if (isset($ok)) {
                            echo '<label style="color: green;">'.$ok.'</label>';
                        }
                    ?>
                </div>
            </div>
        </form>
    </div>
</section>
    <!-- Optional JavaScript -->
    <script src="https://cdn.jsdelivr.net/npm/typed.js@2.0.11"></script>
    <script>
		var typed = new Typed('#typed', { strings: ["Mon incroyable <br> portfolio !"], typeSpeed: 75, cursorChar: '_', showCursor: false });
	</script>
    <!-- jQuery first, then Popper.js, then Bootstrap JS -->
    <script src="https://code.jquery.com/jquery-3.5.1.slim.min.js" integrity="sha384-DfXdz2htPH0lsSSs5nCTpuj/zy4C+OGpamoFVy38MVBnE+IbbVYUew+OrCXaRkfj" crossorigin="anonymous"></script>
    <script src="https://cdn.jsdelivr.net/npm/popper.js@1.16.1/dist/umd/popper.min.js" integrity="sha384-9/reFTGAW83EW2RDu2S0VKaIzap3H66lZH81PoYlFhbGU+6BZp6G7niu735Sk7lN" crossorigin="anonymous"></script>
    <script src="https://stackpath.bootstrapcdn.com/bootstrap/4.5.2/js/bootstrap.min.js" integrity="sha384-B4gt1jrGC7Jh4AgTPSdUtOBvfO8shuf57BaghqFfPlYxofvL8/KUEfYiJOMMV+rV" crossorigin="anonymous"></script>
</body>
</html>