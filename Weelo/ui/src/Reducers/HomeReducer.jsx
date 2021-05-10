import {LOADING,PROGRESS,ERROR,PROPERTIES,CHANGE_LOGIN_FORM_EMAIL,CHANGE_LOGIN_FORM_PASSWORD} from 'Types';

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
      case PROPERTIES:
      return {
        ...actualState,
        Data:action.data
      }
      
      default:
        return actualState;
    }
    
  
  }

  