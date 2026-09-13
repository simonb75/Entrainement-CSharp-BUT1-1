# Exercices d'entraînement C# - BUT Informatique (S1)

Ce dépôt contient une série d'exercices progressifs en C# pour s'entraîner aux bases de la programmation (conditions, boucles, tableaux, génération aléatoire).

---

## 📝 Énoncés des Exercices

### 🎬 Exercice 1 : Calculatrice de facture de cinéma
**Thèmes :** `if / else`, types primitifs, conditions.

Un cinéma applique des tarifs selon l'âge et le statut d'étudiant :
- **Moins de 14 ans :** 5 €
- **De 14 à 26 ans :** 8 € (si étudiant) ou 10 € (si non étudiant)
- **Plus de 65 ans :** 7 €
- **Plein tarif (autres cas) :** 12 €

**Consignes :** Demander l'âge (et le statut étudiant si nécessaire) et afficher le tarif final.

---

### 🔑 Exercice 2 : Validation de mot de passe
**Thèmes :** Boucle `while`, constantes, compteurs.

**Consignes :**
1. Définir un mot de passe secret dans une constante (`BUTInfo2026`).
2. Demander la saisie du mot de passe à l'utilisateur.
3. Autoriser un maximum de **3 tentatives**.
4. Afficher "Accès autorisé" en cas de succès, ou "Compte bloqué après 3 essais" en cas d'échec.

---

### 📊 Exercice 3 : Statistiques d'une promotion
**Thèmes :** Tableaux (`double[]`), boucles `for` et `foreach`.

**Consignes :**
1. Demander à l'utilisateur le nombre d'étudiants $N$.
2. Saisir les $N$ notes dans un tableau.
3. Calculer et afficher :
   - La moyenne générale de la promotion.
   - La note la plus haute et la note la plus basse.
   - Le nombre d'étudiants ayant obtenu la moyenne ($\ge 10$).

---

### 🎲 Exercice 4 : Le jeu du "Plus ou Moins"
**Thèmes :** Boucle `do-while`, classe `Random` (ex : [int a = new Random().Next(x, y)] génères dans a un nombre allant de x à y-1).

**Consignes :**
1. Générer un nombre aléatoire entre 1 et 100 inclus.
2. Faire deviner le nombre à l'utilisateur en lui indiquant à chaque essai s'il est "Plus grand" ou "Plus petit".
3. Compter et afficher le nombre de tentatives nécessaires pour trouver la solution.
