import { Fragment } from "react/jsx-runtime";
import "./App.css";
import { LoginPage } from "./feature/auth/pages/LoginPage";
import { Route, Routes } from "react-router-dom";

function App() {
  return (
    <Fragment>
      <Routes>
        <Route path="/login" element={<LoginPage />} />
      </Routes>
    </Fragment>
  );
}

export default App;
