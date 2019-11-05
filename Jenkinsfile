pipeline {
   agent any
   
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
          expression { "${Environment}" == 'Refresh' }
        }
        steps {
          echo "Pipeline refreshed"
        }
      }
      stage('Build') {
	    when {
          expression { "${Environment}" == 'Build' }
		  expression { "${Environment}" == 'QA'}
        }
         steps {
            echo 'Building the application'
         }
      }
	  stage('QA') {
		 expression { "${Environment}" == 'QA'}
         steps {
            echo 'Deploying on QA'
         }
      }
	  stage('Stage') {
		 expression { "${Environment}" == 'Stage'}
         steps {
            echo 'Deploying on Stage'
         }
      }
	  stage('Prod') {
		 expression { "${Environment}" == 'Prod'}
         steps {
            echo 'Deploying on Prod'
         }
      }
   }
}