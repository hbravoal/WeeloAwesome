import React,{Fragment,useEffect,useReducer,useContext} from 'react';
import {useHistory} from 'react-router-dom';
import {LogOut} from 'Services/authService';
import Loading from 'Components/Layout/Loading';
import bannerImage from 'assets/img/banner/login.jpg';

const Login = () => {
  const handleFOrmSubmitChange = async e => {    
    e.preventDefault();
    
     var isSucess=await LoginConsume(state.Code.value,dispatch);
     
    
   
  } 

  const handleEmailChange = (e) => {
    let error= null;
    let value =e.target.value;
    if(value ===''){
      error='Debe diligenciar Email';

    }
    var defaultError ={
      HaveError:false,
      Message:'',
      Redirect:''
    };
    
  }

    return (
      <Fragment>
        
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
                      onChange={handleEmailChange} value={state.Email.value} required placeholder="You must enter your Email"/>
                    <span className="bar"></span>
                    {state.Email.error && <p className="error"> {state.Email.error}</p>} 
                    {state.Errors.HaveError &&<p className="error"> {state.Errors.Message}</p> }
                    {Errors.HaveError &&<p className="error"> {Errors.Message}</p> }
                  </div>
                
                 
                
                  <div className="py-3 d-flex justify-content-center align-items-center">
                    <a className="mx-3 button" href="./">Cancelar</a>  
                    <a className={`mx-3 button button-yellow`}   href="Submit" onClick={handleFOrmSubmitChange}>Continuar</a>
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