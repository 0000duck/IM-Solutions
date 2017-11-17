pipeline {
  agent any
  stages {
    stage('Build') {
      steps {
        sh 'nuget restore InterlancedMinds-Solutions.sln'
        sh "xbuild InterlancedMinds-Solutions.sln /p:Configuration=Release /p:Platform=\"Any CPU\" /p:ProductVersion=1.0.0.${env.BUILD_NUMBER}"
      }
    }
    stage('Archive') {
      steps {
        archive 'Build/**'
      }
    }
    stage('Cleanup') {
      steps {
        cleanWs(cleanWhenAborted: true, cleanWhenFailure: true, cleanWhenNotBuilt: true, cleanWhenSuccess: true, cleanWhenUnstable: true)
      }
    }
  }
}