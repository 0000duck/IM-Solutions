pipeline
{

	agent any
	
	node {
		stage 'Checkout'
			checkout scm

		stage 'Build'
			sh 'nuget restore InterlancedMinds-Solutions.sln'
			sh "\"${tool 'MSBuild'}\" InterlancedMinds-Solutions.sln /p:Configuration=Release /p:Platform=\"Any CPU\" /p:ProductVersion=1.0.0.${env.BUILD_NUMBER}"

		stage 'Archive'
			archive 'Build/**'

	}
}