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
    stage('Archive') {
      parallel {
        stage('Archive') {
          steps {
            archive 'Build/**'
          }
        }
        stage('Zipping It All Up') {
          steps {
            sh 'zip -r ${env.BUILD_NUMBER}.zip Build'
          }
        }
      }
    }
    stage('Cleanup') {
      parallel {
        stage('Cleanup') {
          steps {
            cleanWs(cleanWhenAborted: true, cleanWhenFailure: true, cleanWhenNotBuilt: true, cleanWhenSuccess: true, cleanWhenUnstable: true)
          }
        }
        stage('Archive Zip') {
          steps {
            sh 'archive \'${env.BUILD_NUMBER}.zip\''
          }
        }
      }
    }
  }
}