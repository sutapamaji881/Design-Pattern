pipeline {
  agent any
  stages {
    stage('build') {
      steps {
        git(url: 'https://github.com/sutapamaji881', branch: 'master', credentialsId: 'GIT')
      }
    }

    stage('Complie') {
      steps {
        sh 'mvn compile'
      }
    }

    stage('Test') {
      parallel {
        stage('Regression') {
          agent {
            node {
              label 'master'
            }

          }
          steps {
            sh 'mvn test'
          }
        }

        stage('Smoke') {
          agent {
            node {
              label 'node'
            }

          }
          steps {
            sh 'mvn test'
          }
        }

      }
    }

  }
}