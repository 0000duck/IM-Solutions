pipeline {
  agent any
  stages {
    stage('Restore') {
      steps {
        sh 'nuget restore InterlancedMinds-Solutions.sln'
      }
    }
    stage('Build') {
      steps {
        sh '"xbuild InterlancedMinds-Solutions.sln /p:Configuration=Release /p:Platform=\\"Any CPU\\" /p:ProductVersion=1.0.0.${env.BUILD_NUMBER}"'
      }
    }
    stage('Archive') {
      steps {
        sh 'archive \'Build/**\''
      }
    }
    stage('Cleanup') {
      steps {
        cleanWs(cleanWhenAborted: true, cleanWhenFailure: true, cleanWhenSuccess: true, cleanWhenNotBuilt: true, cleanWhenUnstable: true)
      }
    }
  }
}