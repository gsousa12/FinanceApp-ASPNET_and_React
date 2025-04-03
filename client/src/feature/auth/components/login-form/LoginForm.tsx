export const LoginForm = () => {
  return (
    <div className=" flex-col p-10 border-2 border-amber-500">
      <div className="text-5xl font-bold">
        <span>Faça Login</span>
      </div>
      <div className="flex mt-7 gap-2">
        <span>Ainda não tem uma conta?</span>{" "}
        <a className="underline hover:cursor-pointer">Crie agora!</a>
      </div>
    </div>
  );
};
