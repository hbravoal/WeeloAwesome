import {LOADING,PROGRESS,ERROR,RESET_FORM,CHANGE_LOGIN_FORM_EMAIL,CHANGE_LOGIN_FORM_PASSWORD} from 'Types';

export const HomeReducer = (actualState, action)=>{
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
        
      default:
        return actualState;
    }
    
  
  }

  