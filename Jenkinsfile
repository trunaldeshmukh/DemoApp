pipeline {
   agent any
   
   stages {
      stage('Build') {
         steps {
            echo 'Building the application'
         }
      }
	  stage('QA') {
         steps {
            echo 'Deploying on QA'
         }
      }
	  stage('Stage') {
         steps {
            echo 'Deploying on Stage'
         }
      }
	  stage('Prod') {
         steps {
            echo 'Deploying on Prod'
         }
      }
   }
}