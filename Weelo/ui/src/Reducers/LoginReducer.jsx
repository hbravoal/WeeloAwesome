import {LOADING,PROGRESS,ERROR,RESET_FORM,CHANGE_LOGIN_FORM_EMAIL,CHANGE_LOGIN_FORM_PASSWORD} from 'Types';

export const LoginReducer = (actualState, action)=>{
    switch (action.type){
      case LOADING:
      return {
        ...actualState,
        Loading:action.data
      }
      case PROGRESS:
      return {
        ...actualState,
        Progress:action.data
      }
      case ERROR:
      return {
        ...actualState,
        Errors:action.data
      }  
        case CHANGE_LOGIN_FORM_EMAIL:
        return {
          ...actualState,
          Email:action.data,
          
        }
        case CHANGE_LOGIN_FORM_PASSWORD:
        return {
          ...actualState,
          Password:action.data
        }
        
        case RESET_FORM:
            return {
              ...actualState,
              Email:{
                value:'',
                error:false
              },
              Password:{
                value:'',
                error:false
              }
            }
        
      default:
        return actualState;
    }
    
  
  }

  