import {LOADING,PROGRESS,ERROR,RESET_FORM,CHANGE_LOGIN_FORM_EMAIL,CHANGE_LOGIN_FORM_PASSWORD} from 'Types';
import React,{Fragment,useEffect,useReducer,useContext} from 'react';
import {useHistory} from 'react-router-dom';
import bannerImage from 'assets/img/banner/login.jpg';
import {LoginConsume} from 'Services/consumeService';
import LoginFormData from  'Data/LoginFormData';
import Loading from 'Components/Layout/Loading';
import {LoginReducer} from 'Reducers/LoginReducer';
const Login = () => {

  const history = useHistory();

  const [state,dispatch] = useReducer(LoginReducer, LoginFormData);

  useEffect(() => {  
    dispatch({type:PROGRESS,data:70});
    // LogOut();
    dispatch({type:PROGRESS,data:100});
    return () => {
      dispatch({type:PROGRESS,data:0});
    }
  }, [])

  const handleFOrmSubmitChange = async e => {    
    e.preventDefault();
    dispatch({type:PROGRESS,data:70});
     var isSucess=await LoginConsume('superadmin@gmail.com','123Pa$$word!');
     dispatch({type:PROGRESS,data:100});
     if(!isSucess){
      dispatch({type:ERROR,data:{
        HaveError:true,
        Message:'Your Credentials are not match.',
      }});    
       return ;
     }
     if(isSucess){
        setTimeout(()=>{
          history.push("/Home");
        },2000)

  }
    
   
  } 

  const handleEmailChange = (e) => {
    let error= null;
    let value =e.target.value;
    if(value ===''){
      error='You must enter a Email';
    }
    dispatch({type:ERROR,data:{HaveError:false}});
    dispatch({type:CHANGE_LOGIN_FORM_EMAIL,data:{value,error}});    
  }
  const handlePasswordChange = (e) => {
    let error= null;
    let value =e.target.value;
    if(value ===''){
      error='You must enter a Password';
    }  
    dispatch({type:ERROR,data:{HaveError:false}});
    dispatch({type:CHANGE_LOGIN_FORM_PASSWORD,data:{value,error}});    
  }

    return (
      <Fragment>
        <Loading progress={state.Progress}></Loading>      
          <div className="container-fluid animated fadeIn">
          <div className="row">
            <div className="col-md-6 d-none d-block p-0"><img className="img-login w-100" src={bannerImage} alt="BannerImage"/></div>
            <div className="col-md-6 d-flex align-items-center justify-content-center">
              <div className="content-login">
                <h5 className="pb-4">Welcome!</h5>
                <p> HBravoAl's Test for Weelo.</p>
                <form className="h-100 " onSubmit={(e)=>e.preventDefault()} id="FormLogin">
                <div className="group mb-4">
                    <label className="none">Email</label>
                    <input className="user" id="Email" name="Email"  type="text" 
                      onChange={handleEmailChange} 
                      
                      required 
                      placeholder="hbravoalgmail.com"/>
                    <span className="bar"></span>                    
                    {state.Email.error && <p className="error"> {state.Email.error}</p>} 
                  </div>
                  <div className="group mb-4">
                    <label className="none">Password</label>
                    <input className="user" id="Password" name="Password"  type="password" 
                      onChange={handlePasswordChange} 
                      
                      required 
                      placeholder="mypasss"/>
                    <span className="bar"></span>                    
                    {state.Password.error && <p className="error"> {state.Password.error}</p>} 
                  </div>
                  <div className="group mb-4">                    
                    {state.Errors.HaveError && <p className="error"> {state.Errors.Message}</p>} 
                  </div>
                  <div className="py-3 d-flex justify-content-center align-items-center">
                    <a className="mx-3 button" href="./">Cancelar</a>  
                    <a className={`mx-3 button button-yellow ${(!state.Email.value || !state.Password.value ||  state.Loading ) ? 'disabled' : '' }`}   href="Submit" onClick={handleFOrmSubmitChange}>Continuar</a>
                    
                    </div>
                   
                </form>
              </div>
            </div>
          </div>
        </div>

    </Fragment>
      );
}
 
export default Login;