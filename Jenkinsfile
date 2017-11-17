pipeline {
  agent any
  stages {
    stage('Checkout') {
      steps {
        checkout scm
      }
    }
    stage('Nuget') {
      steps {
        sh 'nuget restore InterlancedMinds-Solutions.sln'
      }
    }
    stage('Build') {
      steps {
        sh "xbuild InterlancedMinds-Solutions.sln /p:Configuration=Release /p:Platform=\"Any CPU\" /p:ProductVersion=1.0.0.${env.BUILD_NUMBER}"
      }
    }
    stage('Zip it up') {
      steps {
        sh 'zip Build.zip Build/*'
      }
    }
    stage('Cleanup') {
      parallel {
        stage('Cleanup') {
          steps {
            cleanWs(cleanWhenAborted: true, cleanWhenFailure: true, cleanWhenNotBuilt: true, cleanWhenSuccess: true, cleanWhenUnstable: true)
          }
        }
        stage('Archive') {
          steps {
            sh 'archive \'Build.zip\''
          }
        }
      }
    }
  }
}