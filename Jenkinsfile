pipeline {
  agent {
    node {
      label 'Windows'
    }

  }
  stages {
    stage('Docker Build') {
      agent any
      steps {
        sh 'docker build -f Dockerfile -t dockerimagewithtest .'
        sh 'docker rm -f container_image_test || true'
        sh 'docker create --name  container_image_test dockerimagewithtest'
        sh 'docker container cp  container_image_test:/app/TestResults/ \'./\''
        sh '''cd TestResults/
cat *'''
      }
    }

    stage('Xunit') {
      steps {
        pwsh 'dotnet test -l:trx || true'
        powershell 'dotnet test -l:trx || true'
      }
    }

  }
}