import { useState } from "react";
import LogoContent from "../../../_shared/components/logo-content/LogoContent";
import { LoginForm } from "../components/login-form/LoginForm";

export const LoginPage = () => {
  const [isLogin, setIsLogin] = useState(true);
  const [formData, setFormData] = useState({
    name: "",
    email: "",
    username: "",
    password: "",
    confirmPassword: "",
  });

  const handleInputChange = (e: React.ChangeEvent<HTMLInputElement>) => {
    const { name, value } = e.target;
    setFormData((prev) => ({
      ...prev,
      [name]: value,
    }));
  };

  const handleSubmit = (e: React.FormEvent) => {
    e.preventDefault();
    // TODO: Implementar lógica de autenticação
    console.log("Form submitted:", formData);
  };

  return (
    <div className="flex h-screen overflow-hidden">
      {/* Lado esquerdo - Formulário */}
      <div className="flex-1 flex p-8 bg-white overflow-y-auto ">
        <div className="w-full  border-1 border-red-600">
          <div className=" border-1 border-blue-600">
            <LogoContent hasIcon={true} />
          </div>
          <LoginForm />
        </div>
      </div>

      {/* Lado direito - Imagem de fundo */}
      <div className="hidden lg:block lg:w-1/2 relative">
        <div className="absolute inset-0 bg-green-600 bg-opacity-40 flex items-center justify-center">
          <div className="text-center text-white p-8">
            <h1 className="text-4xl font-bold mb-4">
              Bem-vindo ao Finance App
            </h1>
            <p className="text-xl">
              Gerencie suas finanças de forma simples e eficiente
            </p>
          </div>
        </div>
      </div>
    </div>
  );
};
