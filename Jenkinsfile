pipeline {
     agent { label 'master' }
    parameters{
     choice(
        name: 'Environment',
        choices: "Refresh\nBuild\nQA\nStage\nProd",
        description: 'Please select the pipeline action'
      )
   } 
    stages {
        stage('Build') {
            steps {
                echo 'Building..'
            }
        }
        stage('Test') {
            steps {
                echo 'Testing..'
            }
        }
        stage('Deploy') {
            steps {
                echo 'Deploying....'
            }
        }
    }
}

