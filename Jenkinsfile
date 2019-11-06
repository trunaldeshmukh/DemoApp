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
      stage('Refresh pipeline') {
        when {
          expression { "${params.Environment}" == 'Refresh' }
        }
        steps {
          echo "Pipeline refreshed"
        }
      }
      stage('Build') {
        when {
         anyOf{
            expression { "${params.Environment}" == 'Build' }
            expression { "${params.Environment}" == 'QA'}
           }
        }
         steps {
            echo 'Building...'
            sh 'dotnet build ./DemoApp/DemoApp.csproj'
         }
      }
      stage('QA') {
         when {
           expression { "${params.Environment}" == 'QA'}
         }
         steps {
            echo 'Deploying on QA'
         }
      }
      stage('Stage') {
        when {
            expression { "${params.Environment}" == 'Stage'}
         }
         steps {
            echo 'Deploying on Stage'
         }
      }
      stage('Prod') {
         when {
            expression { "${params.Environment}" == 'Prod'}
         }
         steps {
            echo 'Deploying on Prod'
         }
      }
   }
}
